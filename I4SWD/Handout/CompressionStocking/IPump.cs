﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStocking
{
    public interface IPump
    {
        void On();

        void Stop();

        void Reverse();
    }
}
