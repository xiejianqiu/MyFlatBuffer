// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SYHCangBaoHuiAward : Table {
  public static FB_SYHCangBaoHuiAward GetRootAsFB_SYHCangBaoHuiAward(ByteBuffer _bb) { return GetRootAsFB_SYHCangBaoHuiAward(_bb, new FB_SYHCangBaoHuiAward()); }
  public static FB_SYHCangBaoHuiAward GetRootAsFB_SYHCangBaoHuiAward(ByteBuffer _bb, FB_SYHCangBaoHuiAward obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SYHCangBaoHuiAward __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MinLevel { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxLevel { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TargetPoint { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AwardIndex { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LayerId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetIndex { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BounuID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_SYHCangBaoHuiAward> CreateFB_SYHCangBaoHuiAward(FlatBufferBuilder builder,
      int ID = 0,
      int MinLevel = -1,
      int MaxLevel = -1,
      int TargetPoint = -1,
      int AwardIndex = -1,
      int LayerId = -1,
      int GetIndex = -1,
      int BounuID = -1) {
    builder.StartObject(8);
    FB_SYHCangBaoHuiAward.AddBounuID(builder, BounuID);
    FB_SYHCangBaoHuiAward.AddGetIndex(builder, GetIndex);
    FB_SYHCangBaoHuiAward.AddLayerId(builder, LayerId);
    FB_SYHCangBaoHuiAward.AddAwardIndex(builder, AwardIndex);
    FB_SYHCangBaoHuiAward.AddTargetPoint(builder, TargetPoint);
    FB_SYHCangBaoHuiAward.AddMaxLevel(builder, MaxLevel);
    FB_SYHCangBaoHuiAward.AddMinLevel(builder, MinLevel);
    FB_SYHCangBaoHuiAward.AddID(builder, ID);
    return FB_SYHCangBaoHuiAward.EndFB_SYHCangBaoHuiAward(builder);
  }

  public static void StartFB_SYHCangBaoHuiAward(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMinLevel(FlatBufferBuilder builder, int MinLevel) { builder.AddInt(1, MinLevel, -1); }
  public static void AddMaxLevel(FlatBufferBuilder builder, int MaxLevel) { builder.AddInt(2, MaxLevel, -1); }
  public static void AddTargetPoint(FlatBufferBuilder builder, int TargetPoint) { builder.AddInt(3, TargetPoint, -1); }
  public static void AddAwardIndex(FlatBufferBuilder builder, int AwardIndex) { builder.AddInt(4, AwardIndex, -1); }
  public static void AddLayerId(FlatBufferBuilder builder, int LayerId) { builder.AddInt(5, LayerId, -1); }
  public static void AddGetIndex(FlatBufferBuilder builder, int GetIndex) { builder.AddInt(6, GetIndex, -1); }
  public static void AddBounuID(FlatBufferBuilder builder, int BounuID) { builder.AddInt(7, BounuID, -1); }
  public static Offset<FB_SYHCangBaoHuiAward> EndFB_SYHCangBaoHuiAward(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHCangBaoHuiAward>(o);
  }
};

public sealed class FB_SYHCangBaoHuiAwardContainer : Table {
  public static FB_SYHCangBaoHuiAwardContainer GetRootAsFB_SYHCangBaoHuiAwardContainer(ByteBuffer _bb) { return GetRootAsFB_SYHCangBaoHuiAwardContainer(_bb, new FB_SYHCangBaoHuiAwardContainer()); }
  public static FB_SYHCangBaoHuiAwardContainer GetRootAsFB_SYHCangBaoHuiAwardContainer(ByteBuffer _bb, FB_SYHCangBaoHuiAwardContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SYHCangBaoHuiAwardContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SYHCangBaoHuiAwardContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SYHCangBaoHuiAward GetItems(int j) { return GetItems(new FB_SYHCangBaoHuiAward(), j); }
  public FB_SYHCangBaoHuiAward GetItems(FB_SYHCangBaoHuiAward obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SYHCangBaoHuiAwardContainer> CreateFB_SYHCangBaoHuiAwardContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SYHCangBaoHuiAwardContainer.AddItems(builder, items);
    return FB_SYHCangBaoHuiAwardContainer.EndFB_SYHCangBaoHuiAwardContainer(builder);
  }

  public static void StartFB_SYHCangBaoHuiAwardContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SYHCangBaoHuiAward>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SYHCangBaoHuiAwardContainer> EndFB_SYHCangBaoHuiAwardContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SYHCangBaoHuiAwardContainer>(o);
  }
  public static void FinishFB_SYHCangBaoHuiAwardContainerBuffer(FlatBufferBuilder builder, Offset<FB_SYHCangBaoHuiAwardContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
