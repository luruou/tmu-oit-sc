using System.Data.SqlClient;
using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Service.Interface;

namespace TMU_OIT_SC.Service.Services
{
    public class ClassService : IClassService
    {
        private IDBFactory _db;
        private ICardService _cardService;

        public ClassService(IDBFactory db, ICardService cardService)
        {
            this._db = db;
            this._cardService = cardService;
        }

        /// <summary>
        /// 取得上課資訊
        /// </summary>
        /// <param name="scID"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ClassInfo>> GetClassInfoAsync(string scID, DateTime date)
        {
            string sql = @"SELECT M.[CLSSRM_ID] SCID, M.[WEEKS] Weeks, CONVERT(VARCHAR(20), M.[CALEN_DATE],111) ClsDate, M.[WEEK] [Week],
M.[AYEARSMS] Smtr, M.[COSID] CosID, RTRIM(M.[OPEN_CLASSID]) ClassID, M.[CH_LESSON] Lesson,
 R1.TEACH_THEME TeachTheme,--授課主題
       R1.TEACH_THEME_E TeachThemeE,
       R1.TEACH_SCHEME  TeachScheme,--授課大綱
       R1.TEACH_SCHEME_E TeachSchemeE,
	   R1.SEQ Seq,
	   M.SECTION [Section]
FROM [ACERACADEMIC].[TMUDB].[dbo].[SegToDateCLassRoom] M 
  INNER JOIN [ACERACADEMIC].[TMUDB].[dbo].TKET930 R1
        ON     R1.AYEARSMS = M.AYEARSMS
           AND R1.COSID = M.COSID
           AND R1.OPEN_CLASSID = M.OPEN_CLASSID
		   AND R1.WEEKS = M.WEEKS
where M.[CLSSRM_ID] = @SCID AND M.[CALEN_DATE] = CAST(@DATE AS Date)";

            var classes = await this._db.TMUSC().QueryAsync<ClassInfo>(sql, new { SCID = scID, DATE = date.ToString("yyyy-MM-dd HH:mm:ss.fff") });

            foreach (var cls in classes)
            {
                cls.Teachers = (await GetTeachersAsync(cls)).ToList();
                cls.Students = (await GetStudentsAsync(cls)).ToList();
            }
            return classes;
        }

        private async Task<IEnumerable<Student>> GetStudentsAsync(ClassInfo model)
        {
            var students = await this._db.TMUSC().QueryAsync<Student>(@"SELECT std.[StdNo]
      ,std.[ChiName] [Name]
      ,RTRIM(std.[EngName]) [NameE]
  FROM [ACERACADEMIC].[TMUAcademic].[dbo].[cos_smtr_stdregi] r 
  JOIN [ACERACADEMIC].[TMUAcademic].[dbo].[DatStdBasic] std
  ON r.sel_std_no = std.StdNo
  WHERE r.sel_smtr = @Smtr AND r.sel_cos_id = @CosID AND r.sel_cos_class = @ClassID", model);


            foreach (var s in students)
            {
                s.CardID = await this._cardService.GetStudentCardIDAsync(s.StdNo);
                s.CardID = Convert.ToInt32(s.CardID).ToString("X4");
            }
#if DEBUG
            ((List<Student>)students).Add(new Student()
            {
                Name = "盧如漚",
                NameE = "Lu RuOu",
                StdNo = "104101",
                CardID = "90A338D8"
            });
            ((List<Student>)students).Add(new Student()
            {
                Name = "黃玫玲",
                NameE = "MeiLing Huang",
                StdNo = "094046",
                CardID = "E9926763"
            });
#else
 ((List<Student>)students).Add(new Student()
            {
                Name = "盧如漚",
                NameE = "Lu RuOu",
                StdNo = "104101",
                CardID = "90A338D8"
            });
             ((List<Student>)students).Add(new Student()
            {
                Name = "黃玫玲",
                NameE = "MeiLing Huang",
                StdNo = "094046",
                CardID = "E9926763"
            });
#endif
            return students;
        }

        private async Task<IEnumerable<Teacher>> GetTeachersAsync(ClassInfo model)
        {
            var teachers = await this._db.TMUSC().QueryAsync<Teacher>(@"
SELECT 
R2.ACNT ID,--教師員編
R5.CH_NAME Name,--授課教師
R5.ENGNAME NameE
FROM [ACERACADEMIC].[TMUDB].[dbo].TKET940 R2 
LEFT JOIN [ACERACADEMIC].[TMUDB].[dbo].POST020 R5 ON R5.ACNT = R2.ACNT
WHERE R2.AYEARSMS= @Smtr AND R2.COSID = @CosID AND R2.OPEN_CLASSID = @ClassID AND R2.SEQ = @Seq", model);

            foreach (var t in teachers)
                t.ImageBase64 = GetTeacherPhotoBase64String(t.ID);
            return teachers;

        }

        private string GetTeacherPhotoBase64String(string empID)
        {
            string base64String = "";
            using (SqlConnection con = new(this._db.TMUSC().ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new("SELECT photo FROM [PAPOVA].[TmuHr].[dbo].[s10_photo] WHERE emp_id = @empid", con);
                cmd.Parameters.Add(new SqlParameter("empid", empID));
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (dr["photo"] != null && dr["photo"] != DBNull.Value)
                        {
                            byte[] bytes = (byte[])(dr["photo"]);
                            base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                            if (!String.IsNullOrEmpty(base64String))
                                base64String = "data:image/png;base64," + base64String;
                        }
                        break;
                    }
                }
                con.Close();
            }
            return base64String;
        }
    }
}
