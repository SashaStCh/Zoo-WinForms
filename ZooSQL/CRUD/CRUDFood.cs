using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class CRUDFood
    {
        #region Singleton
        private static CRUDFood instance;

        private CRUDFood()
        {

        }

        public static CRUDFood Instance
        {
            get
            {
                if (CRUDFood.instance == null)
                {
                    CRUDFood.instance = new CRUDFood();
                }
                return CRUDFood.instance;
            }
        }
        #endregion Singleton
        public void Create()
        {

        }

        public void Update()
        {

        }

        public void Delete(String id)
        {
            Food food = ZooRepository.Instance.FoodSet.First(i => i.food_name == id);
            ZooRepository.Instance.FoodSet.Remove(food);
            ZooRepository.Instance.SaveChanges();
        }
    }
}
