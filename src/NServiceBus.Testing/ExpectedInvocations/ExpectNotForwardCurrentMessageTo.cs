﻿namespace NServiceBus.Testing
{
    using System;
    using System.Linq;

    class ExpectNotForwardCurrentMessageTo : ExpectInvocation
    {
        public ExpectNotForwardCurrentMessageTo(Func<string, bool> check = null)
        {
            this.check = check ?? (s => true);
        }

        public override void Validate(TestableMessageHandlerContext context)
        {
            if (context.ForwardedMessages.Any(m => check(m)))
            {
                Fail("Expected the incoming message not to be forwarded but a forwarded message matching your constraints was found.");
            }
        }

        readonly Func<string, bool> check;
    }
}