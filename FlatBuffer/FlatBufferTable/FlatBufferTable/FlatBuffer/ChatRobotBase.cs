// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChatRobotBase : Table {
  public static FB_ChatRobotBase GetRootAsFB_ChatRobotBase(ByteBuffer _bb) { return GetRootAsFB_ChatRobotBase(_bb, new FB_ChatRobotBase()); }
  public static FB_ChatRobotBase GetRootAsFB_ChatRobotBase(ByteBuffer _bb, FB_ChatRobotBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChatRobotBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LimitLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LimitMissionID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChatRobotBase> CreateFB_ChatRobotBase(FlatBufferBuilder builder,
      int Id = 0,
      int LimitLevel = -1,
      int LimitMissionID = -1) {
    builder.StartObject(3);
    FB_ChatRobotBase.AddLimitMissionID(builder, LimitMissionID);
    FB_ChatRobotBase.AddLimitLevel(builder, LimitLevel);
    FB_ChatRobotBase.AddId(builder, Id);
    return FB_ChatRobotBase.EndFB_ChatRobotBase(builder);
  }

  public static void StartFB_ChatRobotBase(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLimitLevel(FlatBufferBuilder builder, int LimitLevel) { builder.AddInt(1, LimitLevel, -1); }
  public static void AddLimitMissionID(FlatBufferBuilder builder, int LimitMissionID) { builder.AddInt(2, LimitMissionID, -1); }
  public static Offset<FB_ChatRobotBase> EndFB_ChatRobotBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatRobotBase>(o);
  }
};

public sealed class FB_ChatRobotBaseContainer : Table {
  public static FB_ChatRobotBaseContainer GetRootAsFB_ChatRobotBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ChatRobotBaseContainer(_bb, new FB_ChatRobotBaseContainer()); }
  public static FB_ChatRobotBaseContainer GetRootAsFB_ChatRobotBaseContainer(ByteBuffer _bb, FB_ChatRobotBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChatRobotBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChatRobotBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChatRobotBase GetItems(int j) { return GetItems(new FB_ChatRobotBase(), j); }
  public FB_ChatRobotBase GetItems(FB_ChatRobotBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChatRobotBaseContainer> CreateFB_ChatRobotBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChatRobotBaseContainer.AddItems(builder, items);
    return FB_ChatRobotBaseContainer.EndFB_ChatRobotBaseContainer(builder);
  }

  public static void StartFB_ChatRobotBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChatRobotBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChatRobotBaseContainer> EndFB_ChatRobotBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChatRobotBaseContainer>(o);
  }
  public static void FinishFB_ChatRobotBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChatRobotBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
