// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CoolDownTime : Table {
  public static FB_CoolDownTime GetRootAsFB_CoolDownTime(ByteBuffer _bb) { return GetRootAsFB_CoolDownTime(_bb, new FB_CoolDownTime()); }
  public static FB_CoolDownTime GetRootAsFB_CoolDownTime(ByteBuffer _bb, FB_CoolDownTime obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CoolDownTime __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CDTime { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CDGroupId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_CoolDownTime> CreateFB_CoolDownTime(FlatBufferBuilder builder,
      int Id = 0,
      int CDTime = 0,
      int CDGroupId = 0) {
    builder.StartObject(3);
    FB_CoolDownTime.AddCDGroupId(builder, CDGroupId);
    FB_CoolDownTime.AddCDTime(builder, CDTime);
    FB_CoolDownTime.AddId(builder, Id);
    return FB_CoolDownTime.EndFB_CoolDownTime(builder);
  }

  public static void StartFB_CoolDownTime(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddCDTime(FlatBufferBuilder builder, int CDTime) { builder.AddInt(1, CDTime, 0); }
  public static void AddCDGroupId(FlatBufferBuilder builder, int CDGroupId) { builder.AddInt(2, CDGroupId, 0); }
  public static Offset<FB_CoolDownTime> EndFB_CoolDownTime(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CoolDownTime>(o);
  }
};

public sealed class FB_CoolDownTimeContainer : Table {
  public static FB_CoolDownTimeContainer GetRootAsFB_CoolDownTimeContainer(ByteBuffer _bb) { return GetRootAsFB_CoolDownTimeContainer(_bb, new FB_CoolDownTimeContainer()); }
  public static FB_CoolDownTimeContainer GetRootAsFB_CoolDownTimeContainer(ByteBuffer _bb, FB_CoolDownTimeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CoolDownTimeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CoolDownTimeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CoolDownTime GetItems(int j) { return GetItems(new FB_CoolDownTime(), j); }
  public FB_CoolDownTime GetItems(FB_CoolDownTime obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CoolDownTimeContainer> CreateFB_CoolDownTimeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CoolDownTimeContainer.AddItems(builder, items);
    return FB_CoolDownTimeContainer.EndFB_CoolDownTimeContainer(builder);
  }

  public static void StartFB_CoolDownTimeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CoolDownTime>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CoolDownTimeContainer> EndFB_CoolDownTimeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CoolDownTimeContainer>(o);
  }
  public static void FinishFB_CoolDownTimeContainerBuffer(FlatBufferBuilder builder, Offset<FB_CoolDownTimeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
