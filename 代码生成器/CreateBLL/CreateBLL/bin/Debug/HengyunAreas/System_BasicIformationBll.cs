//=============================================================
/*
   类名称:System_BasicIformationDal
   类描述：
   生成日期：2018-08-30 16:28:26
*/              
//=============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hengyun.Areas.BLL;
using Hengyun.Areas.IBLL;
using Hengyun.Areas.IDAL;
using Hengyun.Areas.DAL;
using Hengyun.Areas.MODEL;
namespace  Hengyun.Areas.BLL
{

 public class System_BasicIformationBll: BaseBll<System_BasicIformation>,ISystem_BasicIformationBll
   {

       public override IBaseDal<System_BasicIformation> Dal
       {
          get   
          {   
             return new System_BasicIformationDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


