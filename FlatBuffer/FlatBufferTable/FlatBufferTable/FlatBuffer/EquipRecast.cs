// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipRecast : Table {
  public static FB_EquipRecast GetRootAsFB_EquipRecast(ByteBuffer _bb) { return GetRootAsFB_EquipRecast(_bb, new FB_EquipRecast()); }
  public static FB_EquipRecast GetRootAsFB_EquipRecast(ByteBuffer _bb, FB_EquipRecast obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipRecast __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MustItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MustItemNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LowItemNum { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighItemId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HighItemNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GoldNum { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_EquipRecast> CreateFB_EquipRecast(FlatBufferBuilder builder,
      int Id = 0,
      int MustItemId = -1,
      int MustItemNum = -1,
      int LowItemId = -1,
      int LowItemNum = -1,
      int HighItemId = -1,
      int HighItemNum = -1,
      int GoldId = -1,
      int GoldNum = -1) {
    builder.StartObject(9);
    FB_EquipRecast.AddGoldNum(builder, GoldNum);
    FB_EquipRecast.AddGoldId(builder, GoldId);
    FB_EquipRecast.AddHighItemNum(builder, HighItemNum);
    FB_EquipRecast.AddHighItemId(builder, HighItemId);
    FB_EquipRecast.AddLowItemNum(builder, LowItemNum);
    FB_EquipRecast.AddLowItemId(builder, LowItemId);
    FB_EquipRecast.AddMustItemNum(builder, MustItemNum);
    FB_EquipRecast.AddMustItemId(builder, MustItemId);
    FB_EquipRecast.AddId(builder, Id);
    return FB_EquipRecast.EndFB_EquipRecast(builder);
  }

  public static void StartFB_EquipRecast(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMustItemId(FlatBufferBuilder builder, int MustItemId) { builder.AddInt(1, MustItemId, -1); }
  public static void AddMustItemNum(FlatBufferBuilder builder, int MustItemNum) { builder.AddInt(2, MustItemNum, -1); }
  public static void AddLowItemId(FlatBufferBuilder builder, int LowItemId) { builder.AddInt(3, LowItemId, -1); }
  public static void AddLowItemNum(FlatBufferBuilder builder, int LowItemNum) { builder.AddInt(4, LowItemNum, -1); }
  public static void AddHighItemId(FlatBufferBuilder builder, int HighItemId) { builder.AddInt(5, HighItemId, -1); }
  public static void AddHighItemNum(FlatBufferBuilder builder, int HighItemNum) { builder.AddInt(6, HighItemNum, -1); }
  public static void AddGoldId(FlatBufferBuilder builder, int GoldId) { builder.AddInt(7, GoldId, -1); }
  public static void AddGoldNum(FlatBufferBuilder builder, int GoldNum) { builder.AddInt(8, GoldNum, -1); }
  public static Offset<FB_EquipRecast> EndFB_EquipRecast(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipRecast>(o);
  }
};

public sealed class FB_EquipRecastContainer : Table {
  public static FB_EquipRecastContainer GetRootAsFB_EquipRecastContainer(ByteBuffer _bb) { return GetRootAsFB_EquipRecastContainer(_bb, new FB_EquipRecastContainer()); }
  public static FB_EquipRecastContainer GetRootAsFB_EquipRecastContainer(ByteBuffer _bb, FB_EquipRecastContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipRecastContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipRecastContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipRecast GetItems(int j) { return GetItems(new FB_EquipRecast(), j); }
  public FB_EquipRecast GetItems(FB_EquipRecast obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipRecastContainer> CreateFB_EquipRecastContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipRecastContainer.AddItems(builder, items);
    return FB_EquipRecastContainer.EndFB_EquipRecastContainer(builder);
  }

  public static void StartFB_EquipRecastContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipRecast>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipRecastContainer> EndFB_EquipRecastContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipRecastContainer>(o);
  }
  public static void FinishFB_EquipRecastContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipRecastContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
