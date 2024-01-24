using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooSQL
{
    class ZooRepository
    {
        private static ZooModelContainer instance;

        private ZooRepository()
        {

        }

        public static ZooModelContainer Instance
        {
            get
            {
                if (ZooRepository.instance == null)
                {
                    ZooRepository.instance = new ZooModelContainer();
                }
                return ZooRepository.instance;
            }
        }
    }
}
