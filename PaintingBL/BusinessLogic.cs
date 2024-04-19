using PaintingModel;
using PaintingDL;
namespace PaintingBL
{
    public class BusinessLogic
    {
       
        public List<Model> GMS()
        {
            DataLayer dataServices = new DataLayer();
            return dataServices.GMS();

        }
    }
}
