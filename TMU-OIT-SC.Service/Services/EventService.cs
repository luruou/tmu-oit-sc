using AutoMapper;
using TMU_OIT_SC.Model.DB;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Model.ViewModels;
using TMU_OIT_SC.Service.Interface;
using System;

namespace TMU_OIT_SC.Service.Services
{
    public class EventService : IEventService
    {
        private IMapper _mapper;

        private IClassService _classService;
        private IBorrowService _borrowService;
        private ITimeSectionService _timeSectionService;

        public EventService(IMapper mapper, IClassService classService, IBorrowService borrowService, ITimeSectionService timeSectionService)
        {
            this._mapper = mapper;

            this._classService = classService;
            this._borrowService = borrowService;
            this._timeSectionService = timeSectionService;
        }

        public async Task<IEnumerable<EventViewModel>> GetAsync(string scID, DateTime date)
        {
            List<EventViewModel> events = new();
            if (String.IsNullOrEmpty(scID))
                return events;

            IEnumerable<TimeSection> timeSections = await this._timeSectionService.GetTimeSectionAsync();
            //場地借用
            events.AddRange(await GetBorrowEventAsync(scID, date, timeSections));
            //課程
            events.AddRange(await GetClassEventAsync(scID, date, timeSections));
            //同課程及場地借用 合併成單一Event
            events = MergeEvent(events.OrderBy(e => e.Section).ToList()).ToList();
            return events;
        }

        public async Task<IEnumerable<EventViewModel>> GetAsync(string scID)
        {
            return await GetAsync(scID, DateTime.Now);
        }

        private async Task<IEnumerable<EventViewModel>> GetClassEventAsync(string scID, DateTime date, IEnumerable<TimeSection> timeSections)
        {
            List<EventViewModel> events = new();
            #region map classinfo to event
            var classInfos = await this._classService.GetClassInfoAsync(scID, date);

            foreach (var c in classInfos)
            {
                var sec = timeSections.Where(t => t.Section == c.Section).FirstOrDefault();
                if (sec != null)
                {
                    EventViewModel ev = new();
                    ev = this._mapper.Map(sec, ev);
                    ev = this._mapper.Map(c, ev);
                    events.Add(ev);
                }
            }
            #endregion
            return events;
        }

        private async Task<IEnumerable<EventViewModel>> GetBorrowEventAsync(string scID, DateTime date, IEnumerable<TimeSection> timeSections)
        {
            List<EventViewModel> events = new();
            #region map borrow to event
            var borrowInfos = await this._borrowService.GetBorrowInfoAsync(scID, date);

            foreach (var b in borrowInfos)
            {
                if (!String.IsNullOrEmpty(b.Section) && b.Section.Contains('、'))
                {
                    string[] section = b.Section.Split('、');
                    foreach (var s in section)
                    {
                        var sec = timeSections.Where(t => t.Section.ToString() == s).FirstOrDefault();
                        if (sec != null)
                        {
                            EventViewModel ev = new();
                            ev.Users = new List<EventUserViewModel>
                            {
                                new EventUserViewModel()
                                {
                                    UserID = b.UserID,
                                    Name = b.UserName,
                                    NameE = b.UserName
                                }
                            };
                            ev = this._mapper.Map(sec, ev);
                            ev = this._mapper.Map(b, ev);
                            events.Add(ev);
                        }
                    }
                }
            }
            #endregion
            return events;
        }

        private static IEnumerable<EventViewModel> MergeEvent(List<EventViewModel> models)
        {
            List<EventViewModel> values = new();
            for (int i = 0; i < models.Count; i++)
            {
                EventViewModel e = models[i];
                for (int j = i + 1; j < models.Count; j++)
                {
                    //同EventId 且同描述內容視為同事件
                    if (e.EventID == models[j].EventID && e.Content == models[j].Content)
                    {
                        try
                        {
                            e.TimeRange = string.Concat(e.TimeRange[..5], "-", models[j].TimeRange.AsSpan(6, 5));
                            e.End = models[j].End;
                            DateTime today = DateTime.Now.Date;
                            DateTime start = today.AddHours(Convert.ToDouble(e.Start.Substring(0, 2))).AddMinutes(Convert.ToDouble(e.Start.Substring(3, 2)));
                            DateTime end = today.AddHours(Convert.ToDouble(e.End.Substring(0, 2))).AddMinutes(Convert.ToDouble(e.End.Substring(3, 2)));

                            e.SignInStart = start.AddMinutes(-10).ToString("HH:mm");
                            e.SignInEnd = start.AddMinutes(10).ToString("HH:mm");
                            e.SignOutStart = end.AddMinutes(-10).ToString("HH:mm");
                            e.SignOutEnd = end.AddMinutes(10).ToString("HH:mm");

                            i = j;
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                        break;
                }
                values.Add(e);
            }
            return values;
        }


    }
}
