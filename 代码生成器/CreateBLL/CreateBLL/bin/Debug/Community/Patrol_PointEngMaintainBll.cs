//=============================================================
/*
   类名称:Patrol_PointEngMaintainDal
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

 public class Patrol_PointEngMaintainBll: BaseBll<Patrol_PointEngMaintain>,IPatrol_PointEngMaintainBll
   {

       public override IBaseDal<Patrol_PointEngMaintain> Dal
       {
          get   
          {   
             return new Patrol_PointEngMaintainDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


