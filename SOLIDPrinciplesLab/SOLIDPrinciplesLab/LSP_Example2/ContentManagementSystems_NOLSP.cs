using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOLIDPrinciplesLab.LSP_Example2
{
    public class ContentManagementSystems_NOLSP
    {
        public void ValidateContent(IValidate validation)
        {
            if(validation is GoogleContentValidator)
            {
                // do logic for google
            }
            else if (validation is FacebookContentValidator)
            {
                // do logic for facebook
            }
            validation.validate();
        }
    }
}