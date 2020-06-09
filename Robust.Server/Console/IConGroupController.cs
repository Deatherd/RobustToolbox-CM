﻿using Robust.Server.Interfaces.Player;
using Robust.Shared.Console;

namespace Robust.Server.Console
{
    public interface IConGroupController
    {
        void Initialize();

        bool CanCommand(IPlayerSession session, string cmdName);
        bool CanViewVar(IPlayerSession session);
        bool CanAdminPlace(IPlayerSession session);
        bool CanScript(IPlayerSession session);
        void SetGroup(IPlayerSession session, ConGroupIndex newGroup);
        ConGroupIndex GetGroupIndex(IPlayerSession session);
        string GetGroupName(ConGroupIndex index);
    }
}
