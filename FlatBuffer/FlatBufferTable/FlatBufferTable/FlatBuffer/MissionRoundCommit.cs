// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionRoundCommit : Table {
  public static FB_MissionRoundCommit GetRootAsFB_MissionRoundCommit(ByteBuffer _bb) { return GetRootAsFB_MissionRoundCommit(_bb, new FB_MissionRoundCommit()); }
  public static FB_MissionRoundCommit GetRootAsFB_MissionRoundCommit(ByteBuffer _bb, FB_MissionRoundCommit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionRoundCommit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RoundConfigID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Rounds { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MissionRoundCommit> CreateFB_MissionRoundCommit(FlatBufferBuilder builder,
      int Id = 0,
      int RoundConfigID = -1,
      int Rounds = -1) {
    builder.StartObject(3);
    FB_MissionRoundCommit.AddRounds(builder, Rounds);
    FB_MissionRoundCommit.AddRoundConfigID(builder, RoundConfigID);
    FB_MissionRoundCommit.AddId(builder, Id);
    return FB_MissionRoundCommit.EndFB_MissionRoundCommit(builder);
  }

  public static void StartFB_MissionRoundCommit(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRoundConfigID(FlatBufferBuilder builder, int RoundConfigID) { builder.AddInt(1, RoundConfigID, -1); }
  public static void AddRounds(FlatBufferBuilder builder, int Rounds) { builder.AddInt(2, Rounds, -1); }
  public static Offset<FB_MissionRoundCommit> EndFB_MissionRoundCommit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundCommit>(o);
  }
};

public sealed class FB_MissionRoundCommitContainer : Table {
  public static FB_MissionRoundCommitContainer GetRootAsFB_MissionRoundCommitContainer(ByteBuffer _bb) { return GetRootAsFB_MissionRoundCommitContainer(_bb, new FB_MissionRoundCommitContainer()); }
  public static FB_MissionRoundCommitContainer GetRootAsFB_MissionRoundCommitContainer(ByteBuffer _bb, FB_MissionRoundCommitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionRoundCommitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionRoundCommitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionRoundCommit GetItems(int j) { return GetItems(new FB_MissionRoundCommit(), j); }
  public FB_MissionRoundCommit GetItems(FB_MissionRoundCommit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionRoundCommitContainer> CreateFB_MissionRoundCommitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionRoundCommitContainer.AddItems(builder, items);
    return FB_MissionRoundCommitContainer.EndFB_MissionRoundCommitContainer(builder);
  }

  public static void StartFB_MissionRoundCommitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionRoundCommit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionRoundCommitContainer> EndFB_MissionRoundCommitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundCommitContainer>(o);
  }
  public static void FinishFB_MissionRoundCommitContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionRoundCommitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
