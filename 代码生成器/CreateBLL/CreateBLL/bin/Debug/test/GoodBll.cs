//=============================================================
/*
   类名称:GoodBLL
   类描述：
   生成日期：2018-08-21 17:38:17
*/              
//=============================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Henyuan.ANJian.BLL;
using Henyuan.ANJian.IBLL;
using Henyuan.ANJian.IDAL;
using Hengyun..ANJian.DAL;
using Hengyun.ANJian.Model;
namespace  Hengyun.BLL
{

 public class GoodBll: BaseBll<Good>,IGoodBll
   {

       public override IBaseDal<Good> Dal
       {
          get   
          {   
             return new GoodDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


