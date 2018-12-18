//=============================================================
/*
   类名称:Patrol_RangeDal
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

 public class Patrol_RangeBll: BaseBll<Patrol_Range>,IPatrol_RangeBll
   {

       public override IBaseDal<Patrol_Range> Dal
       {
          get   
          {   
             return new Patrol_RangeDal(); 
          }
          set 
          {   
            base.Dal = value;  
          }
      }

   }

}


