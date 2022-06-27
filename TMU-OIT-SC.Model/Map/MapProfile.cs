using AutoMapper;
using TMU_OIT_SC.Model.Enum;
using TMU_OIT_SC.Model.Models;
using TMU_OIT_SC.Model.ViewModels;

namespace TMU_OIT_SC.Model.Map
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<TimeSection, EventViewModel>();
            CreateMap<Student, EventUserViewModel>()
                .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.StdNo));
            CreateMap<Teacher, EventUserViewModel>()
                .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.ID));

            CreateMap<BorrowInfo, EventViewModel>()
                .ForMember(dest => dest.EventID, opt => opt.MapFrom(src => src.BorrowID))
                .ForMember(dest => dest.ContentE, opt => opt.MapFrom(src => src.Content))
                .ForMember(dest => dest.MemoE, opt => opt.MapFrom(src => src.Memo))
                .ForMember(dest => dest.ReasonE, opt => opt.MapFrom(src => src.Reason))
                .ForMember(dest => dest.StatusNameE, opt => opt.MapFrom(src => src.StatusName))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => EventType.借地借用))
                .ForMember(dest => dest.Section, opt => opt.Ignore());
            CreateMap<ClassInfo, EventViewModel>()
                .ForMember(dest => dest.EventID, opt => opt.MapFrom(src => src.Smtr + "-" + src.CosID + (String.IsNullOrWhiteSpace(src.ClassID) ? "" : ("-" + src.ClassID))))
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Lesson))
                .ForMember(dest => dest.ContentE, opt => opt.MapFrom(src => src.Lesson))
                .ForMember(dest => dest.Memo, opt => opt.MapFrom(src => src.TeachTheme))
                .ForMember(dest => dest.MemoE, opt => opt.MapFrom(src => src.TeachThemeE))
                .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.TeachScheme))
                .ForMember(dest => dest.ReasonE, opt => opt.MapFrom(src => src.TeachSchemeE))
                .ForMember(dest => dest.Users, opt => opt.MapFrom(src => src.Teachers))
                .ForMember(dest => dest.SubUsers, opt => opt.MapFrom(src => src.Students))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => EventType.課堂));
             
            CreateMap<Student, EventUserViewModel>()
                .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.StdNo));

        }
    }
}
