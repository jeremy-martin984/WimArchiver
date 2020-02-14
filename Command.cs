using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WimArchiver
{
    public class Command
    {
        private string assetNumber;
        private string modelName;
        private string systemCommand;

        public void Asset(string an)
        {
            assetNumber = an;
        }
        public string GetAssetNumber()
        {
            return assetNumber;
        }
        public void ModelName(string n)
        {
            modelName = n;
        }
        public string GetModelName()
        {
            return modelName;
        }
        public void DISMCMD(string cmd)
        {
            systemCommand = cmd;
        }
        public string GetCMD()
        {
            return systemCommand;
        }
    }
    
}
