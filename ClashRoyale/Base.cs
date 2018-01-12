﻿namespace ClashRoyale
{
    using ClashRoyale.Api;
    using ClashRoyale.Crypto.Randomizers;
    using ClashRoyale.Extensions.Game;
    using ClashRoyale.Files;
    using ClashRoyale.Files.Csv;
    using ClashRoyale.Files.Sc;
    using ClashRoyale.Messages;

    public static class Base
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Program"/> has been initialized.
        /// </summary>
        public static bool Initialized
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public static void Initialize()
        {
            if (Base.Initialized)
            {
                return;
            }

            // Sentry.Initialize();
            XorShift.Initialize();

            ScFiles.Initialize();
            CsvFiles.Initialize();
            Fingerprint.Initialize();
            Home.Initialize();

            Globals.Initialize();
            ClientGlobals.Initialize();

            Factory.Initialize();
            IpRequester.Initialize();

            Tests.Initialize();

            Base.Initialized = true;;
        }
    }
}
