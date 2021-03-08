﻿using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Rapairs => this.repairs.AsReadOnly();

        public void AddRepair(IRepair repair)
        {
            this.repairs.Add(repair);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");

            foreach (var repair in this.repairs)
            {
                sb.AppendLine($"   {repair}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}