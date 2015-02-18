namespace SPAChallenge.Business
{
    using System.Collections.Generic;
    using System.Linq;
    using SPAChallenge.Business.Model;
    using SPAChallenge.Business.Persistence;

    public class Repository
    {
        private readonly ScreenMapper ScreenMapper;

        public Repository()
        {
            ScreenMapper = new ScreenMapper();
        }

        public IList<ScreenModel> GetScreens()
        {
            IList<ScreenModel> screens;
            
            using (var context = new EFContext())
            {
                screens = context.Screens.OrderBy(screen => screen.System).ToList().Select(screen => ScreenMapper.GetWrapperScreenModel(screen)).ToList();
            }
            return screens;
        }

        public ScreenWithFieldsModel GetScreen(int id)
        {
            ScreenWithFieldsModel screen;
            using (var context = new EFContext())
            {
                screen = ScreenMapper.GetWrapperScreenWithFieldsModel(context.Screens.FirstOrDefault(_screen => _screen.ID == id));
            }
            return screen;
        }
    }
}
