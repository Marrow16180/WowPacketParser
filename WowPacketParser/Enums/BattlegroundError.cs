namespace WowPacketParser.Enums
{
    public enum BattlegroundError
    {
        IncorrectBattlegroundId           = 0,
        NotReport                         = -1,
        GroupJoinDeserter                 = -2,
        IcorrectPartySize                 = -3,
        TooManyQueues                     = -4,
        NotAllowedWhileQueuedForNonRated  = -5,
        NotAllowedWhileQueuedForArena     = -6,
        TeamHasLeftArenaQueue             = -7,
        NotAllowedInBattleground          = -8,
        Unknown9                          = -9,
        PlayersNotInSameRangeIndex        = -10,
        CouldntJoinQueueInTime            = -11,
        JoinFailedAsGroup                 = -12,
        CantJoinWhileUsingLFG             = -13,
        NotAllowedWhileInRandomQueue      = -14,
        NotAllowedWhileInNotRandomQueue   = -15

    }
}
