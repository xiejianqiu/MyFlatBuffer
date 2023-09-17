// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActZhuTianBaoLun : Table {
  public static FB_ActZhuTianBaoLun GetRootAsFB_ActZhuTianBaoLun(ByteBuffer _bb) { return GetRootAsFB_ActZhuTianBaoLun(_bb, new FB_ActZhuTianBaoLun()); }
  public static FB_ActZhuTianBaoLun GetRootAsFB_ActZhuTianBaoLun(ByteBuffer _bb, FB_ActZhuTianBaoLun obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActZhuTianBaoLun __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Weight { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool LuckyTrigger { get { int o = __offset(12); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_ActZhuTianBaoLun> CreateFB_ActZhuTianBaoLun(FlatBufferBuilder builder,
      int Id = 0,
      int Type = -1,
      int RewardNum = -1,
      int Weight = -1,
      bool LuckyTrigger = false) {
    builder.StartObject(5);
    FB_ActZhuTianBaoLun.AddWeight(builder, Weight);
    FB_ActZhuTianBaoLun.AddRewardNum(builder, RewardNum);
    FB_ActZhuTianBaoLun.AddType(builder, Type);
    FB_ActZhuTianBaoLun.AddId(builder, Id);
    FB_ActZhuTianBaoLun.AddLuckyTrigger(builder, LuckyTrigger);
    return FB_ActZhuTianBaoLun.EndFB_ActZhuTianBaoLun(builder);
  }

  public static void StartFB_ActZhuTianBaoLun(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddRewardNum(FlatBufferBuilder builder, int RewardNum) { builder.AddInt(2, RewardNum, -1); }
  public static void AddWeight(FlatBufferBuilder builder, int Weight) { builder.AddInt(3, Weight, -1); }
  public static void AddLuckyTrigger(FlatBufferBuilder builder, bool LuckyTrigger) { builder.AddBool(4, LuckyTrigger, false); }
  public static Offset<FB_ActZhuTianBaoLun> EndFB_ActZhuTianBaoLun(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActZhuTianBaoLun>(o);
  }
};

public sealed class FB_ActZhuTianBaoLunContainer : Table {
  public static FB_ActZhuTianBaoLunContainer GetRootAsFB_ActZhuTianBaoLunContainer(ByteBuffer _bb) { return GetRootAsFB_ActZhuTianBaoLunContainer(_bb, new FB_ActZhuTianBaoLunContainer()); }
  public static FB_ActZhuTianBaoLunContainer GetRootAsFB_ActZhuTianBaoLunContainer(ByteBuffer _bb, FB_ActZhuTianBaoLunContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActZhuTianBaoLunContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActZhuTianBaoLunContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActZhuTianBaoLun GetItems(int j) { return GetItems(new FB_ActZhuTianBaoLun(), j); }
  public FB_ActZhuTianBaoLun GetItems(FB_ActZhuTianBaoLun obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActZhuTianBaoLunContainer> CreateFB_ActZhuTianBaoLunContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActZhuTianBaoLunContainer.AddItems(builder, items);
    return FB_ActZhuTianBaoLunContainer.EndFB_ActZhuTianBaoLunContainer(builder);
  }

  public static void StartFB_ActZhuTianBaoLunContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActZhuTianBaoLun>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActZhuTianBaoLunContainer> EndFB_ActZhuTianBaoLunContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActZhuTianBaoLunContainer>(o);
  }
  public static void FinishFB_ActZhuTianBaoLunContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActZhuTianBaoLunContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
