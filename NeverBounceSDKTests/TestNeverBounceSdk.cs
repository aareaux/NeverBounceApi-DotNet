﻿// Author: Mike Mollick <mike@neverbounce.com>
//
// Copyright (c) 2017 NeverBounce
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using NeverBounce;
using NeverBounce.Exceptions;
using NUnit.Framework;

namespace NeverBounceSDKTests
{
    [TestFixture]
    public class TestNeverBounceSdk
    {
        [Test]
        public void TestNeverBounceSdkSetup()
        {
            var nb = new NeverBounceSdk("fake_api_key");
            Assert.IsNotNull(nb.Account);
            Assert.IsNotNull(nb.Jobs);
            Assert.IsNotNull(nb.POE);
            Assert.IsNotNull(nb.Single);
        }
        
        [Test]
        public void TestNeverBounceAccountInfo()
        {
            var nb = new NeverBounceSdk("fake_api_key");            
            var resp = Assert.ThrowsAsync<AuthException>(async () =>
                await nb.Account.Info());
            StringAssert.Contains("We were unable to authenticate your request", resp.Message);
            StringAssert.Contains("(auth_failure)", resp.Message);
        }
    }
}