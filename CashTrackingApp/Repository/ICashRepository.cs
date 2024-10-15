﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashTrackingApp.Repository;

public interface ICashRepository
{
    double GetBalance();

    double UpdateBalance(double newBalance);
}
