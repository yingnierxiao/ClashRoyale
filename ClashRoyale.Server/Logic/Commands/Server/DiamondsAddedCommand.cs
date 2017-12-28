﻿namespace ClashRoyale.Server.Logic.Commands.Server
{
    using ClashRoyale.Extensions;
    using ClashRoyale.Server.Logic.Mode;
    using ClashRoyale.Server.Logic.Player;

    internal class DiamondsAddedCommand : ServerCommand
    {
        internal int Diamonds;

        /// <summary>
        /// Gets the type of this command.
        /// </summary>
        internal override int Type
        {
            get
            {
                return 275;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiamondsAddedCommand"/> class.
        /// </summary>
        public DiamondsAddedCommand()
        {
            // DiamondsAddedCommand.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiamondsAddedCommand"/> class.
        /// </summary>
        public DiamondsAddedCommand(int Diamonds)
        {
            this.Diamonds = Diamonds;
        }

        /// <summary>
        /// Decodes this instance.
        /// </summary>
        internal override void Decode(ByteStream Stream)
        {
            base.Decode(Stream);
            this.Diamonds = Stream.ReadInt();
        }

        /// <summary>
        /// Encodes this instance.
        /// </summary>
        internal override void Encode(ChecksumEncoder Stream)
        {
            base.Encode(Stream);
            Stream.WriteInt(int.MaxValue);
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        internal override byte Execute(GameMode GameMode)
        {
            Player Player = GameMode.Player;

            if (Player != null)
            {
                if (this.Diamonds > 0)
                {
                    GameMode.Player.AddFreeDiamonds(this.Diamonds);
                }

                return 0;
            }

            return 1;
        }
    }
}