//=============================================================
/*
   类名称:Patrol_SecurityPatrolDal
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

 public class Patrol_SecurityPatrolBll: BaseBll<Patrol_SecurityPatrol>,IPatrol_SecurityPatrolBll
   {

       public override IBaseDal<Patrol_SecurityPatrol> Dal
       {
          get   
          {   
             return new Patrol_SecurityPatrolDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


