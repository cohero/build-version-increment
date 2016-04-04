﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BuildVersionIncrement.Incrementors;
using BuildVersionIncrement;
using System.Threading;

namespace Sample.Incrementor
{
    /// <summary>
    /// Example incrementor plugin that calculates the answer to the Ultimate Question of Life, the Universe, and Everything.
    /// </summary>
    public class TheUltimateIncrementor : BaseIncrementor
    {
        /// <summary>
        /// Gets the name of this incrementor.
        /// </summary>
        /// <value>The name.</value>
        public override string Name
        {
            get { return "The Ultimate Incrementor"; }
        }

        /// <summary>
        /// Gets the description of this incrementor.
        /// </summary>
        /// <value>The description.</value>
        public override string Description
        {
            get { return "Calculates the answer to the Ultimate Question of Life, the Universe, and Everything."; }
        }

        /// <summary>
        /// Executes the increment.
        /// </summary>
        /// <param name="context">The context of the increment.</param>
        /// <param name="versionComponent">The version component that needs to be incremented.</param>
        /// <remarks>
        /// Use the method <see cref="IncrementContext.SetNewVersionComponentValue"/> to set the new version component value.
        /// Set the  <see cref="IncrementContext.Continue"/> property to <c>false</c> to skip updating the other component values.
        /// </remarks>
        public override void Increment(IncrementContext context, VersionComponent versionComponent)
        {
            Logger.Write("Ah! I always thought something was fundamentally wrong with the universe.", LogLevel.Info);

            // Set the requested version component of the IncrementContext to the number 42

            context.SetNewVersionComponentValue(versionComponent, "42");
        }
    }
}
