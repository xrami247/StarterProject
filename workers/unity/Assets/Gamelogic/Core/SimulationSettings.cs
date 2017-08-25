using UnityEngine;

// Made a few changes here to optimize performance in Physics based VR experiences

namespace Assets.Gamelogic.Core
{
    public static class SimulationSettings
    {
        public static readonly string PlayerPrefabName = "Player";
        public static readonly string PlayerCreatorPrefabName = "PlayerCreator";
        public static readonly string CubePrefabName = "Cube";

        public static readonly float HeartbeatCheckIntervalSecs = 3;
        public static readonly uint TotalHeartbeatsBeforeTimeout = 3;
        public static readonly float HeartbeatSendingIntervalSecs = 3;

        // Changes were made here! FixedFrameRate is 20 by default, which is bad for physics simulations
        public static readonly int TargetClientFramerate = 90;
        public static readonly int TargetServerFramerate = 90;
        public static readonly int FixedFramerate = 90;

        public static readonly float PlayerCreatorQueryRetrySecs = 4;
        public static readonly float PlayerEntityCreationRetrySecs = 4;

        public static readonly string DefaultSnapshotPath = Application.dataPath + "/../../../snapshots/default.snapshot";
    }
}
