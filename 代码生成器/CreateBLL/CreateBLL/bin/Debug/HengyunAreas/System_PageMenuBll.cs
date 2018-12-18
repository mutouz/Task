//=============================================================
/*
   类名称:System_PageMenuDal
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

 public class System_PageMenuBll: BaseBll<System_PageMenu>,ISystem_PageMenuBll
   {

       public override IBaseDal<System_PageMenu> Dal
       {
          get   
          {   
             return new System_PageMenuDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


