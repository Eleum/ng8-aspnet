﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy.Dating.Domain
{
    public class AuthenticationResult
    {
        public string Token { get; set; }

        public bool IsSuccess { get; set; }

        public IEnumerable<string> Errors { get; set; }
    }
}
