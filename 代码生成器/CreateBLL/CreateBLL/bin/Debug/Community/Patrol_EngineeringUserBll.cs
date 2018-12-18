//=============================================================
/*
   类名称:Patrol_EngineeringUserDal
   类描述：
   生成日期：2018-09-19 17:05:04
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

 public class Patrol_EngineeringUserBll: BaseBll<Patrol_EngineeringUser>,IPatrol_EngineeringUserBll
   {

       public override IBaseDal<Patrol_EngineeringUser> Dal
       {
          get   
          {   
             return new Patrol_EngineeringUserDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


