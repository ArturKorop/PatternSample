﻿using System;

namespace Common.Code
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RunnableAttribute : Attribute
    {
        public bool IsRunnable { get; set; }

        public RunnableAttribute()
        {
            IsRunnable = false;
        }

        public RunnableAttribute(bool isRunnable)
        {
            IsRunnable = isRunnable;
        }
    }
}