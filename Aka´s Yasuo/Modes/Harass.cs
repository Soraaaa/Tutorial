﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK.Events;

namespace AkaYasuo.Modes
{
    partial class Harass
    {
        public static void Harass2()
        {
            if (MenuManager.HarassMenu["QLastHit"].Cast<CheckBox>().CurrentValue && Q.GetTarget(100) == null && !Variables.HaveQ3
    && !Variables.isDashing)
            {
                var obj =
                    EntityManager.MinionsAndMonsters.GetLaneMinions(EntityManager.UnitTeam.Enemy, Variables._Player.ServerPosition, Program.Q.Range)
                        .FirstOrDefault(i => DamageManager._GetQDmg(i) >= i.Health);
                if (obj != null)
                {
                    Program.Q.Cast(obj.ServerPosition);
                }
            }
        }
    }
}

