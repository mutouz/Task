//=============================================================
/*
   类名称:System_AppMenuDal
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

 public class System_AppMenuBll: BaseBll<System_AppMenu>,ISystem_AppMenuBll
   {

       public override IBaseDal<System_AppMenu> Dal
       {
          get   
          {   
             return new System_AppMenuDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


