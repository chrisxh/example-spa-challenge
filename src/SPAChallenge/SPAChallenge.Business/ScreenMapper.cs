namespace SPAChallenge.Business
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using SPAChallenge.Business.Model;
    using SPAChallenge.Business.Persistence;

    public class ScreenMapper
    {
        public ScreenMapper()
        {
            Mapper.CreateMap<Screen, ScreenModel>();
            Mapper.CreateMap<Field, FieldModel>()
                .ForMember(fieldModel => fieldModel.Status, expression => expression.MapFrom(field => field.Status.ToString()))
                .ForMember(fieldModel => fieldModel.LastUpdate, expression => expression.MapFrom(field => field.LastUpdate.ToString()));
            Mapper.CreateMap<Screen, ScreenWithFieldsModel>()
                .ForMember(screenWithFieldsModel => screenWithFieldsModel.LastUpdate, expression => expression.MapFrom(screen => screen.LastUpdate.ToString()))
                .ForMember(screenWithFieldsModel => screenWithFieldsModel.Fields,
                    expression => expression.MapFrom(screen => Mapper.Map<IList<Field>, IList<FieldModel>>(screen.Fields.ToList())));
        }

        public ScreenModel GetWrapperScreenModel(Screen screen)
        {
            return Mapper.Map<Screen, ScreenModel>(screen);
        }

        public ScreenWithFieldsModel GetWrapperScreenWithFieldsModel(Screen screen)
        {
            return Mapper.Map<Screen, ScreenWithFieldsModel>(screen);
        }
    }
}
