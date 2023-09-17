// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TreasureShow : Table {
  public static FB_TreasureShow GetRootAsFB_TreasureShow(ByteBuffer _bb) { return GetRootAsFB_TreasureShow(_bb, new FB_TreasureShow()); }
  public static FB_TreasureShow GetRootAsFB_TreasureShow(ByteBuffer _bb, FB_TreasureShow obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TreasureShow __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TreasureType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelMin { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelMax { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RateShowTitle { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RateShowDesc { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FreeDrop { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MdId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Big { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetShowItemIDList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemIDListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TreasureShow> CreateFB_TreasureShow(FlatBufferBuilder builder,
      int Id = 0,
      int TreasureType = 0,
      int LevelMin = -1,
      int LevelMax = -1,
      int RateShowTitle = -1,
      int RateShowDesc = -1,
      int FreeDrop = -1,
      int MdId = -1,
      int DropId = -1,
      StringOffset Big = default(StringOffset),
      VectorOffset ShowItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(12);
    FB_TreasureShow.AddItemNumList(builder, ItemNumList);
    FB_TreasureShow.AddShowItemIDList(builder, ShowItemIDList);
    FB_TreasureShow.AddBig(builder, Big);
    FB_TreasureShow.AddDropId(builder, DropId);
    FB_TreasureShow.AddMdId(builder, MdId);
    FB_TreasureShow.AddFreeDrop(builder, FreeDrop);
    FB_TreasureShow.AddRateShowDesc(builder, RateShowDesc);
    FB_TreasureShow.AddRateShowTitle(builder, RateShowTitle);
    FB_TreasureShow.AddLevelMax(builder, LevelMax);
    FB_TreasureShow.AddLevelMin(builder, LevelMin);
    FB_TreasureShow.AddTreasureType(builder, TreasureType);
    FB_TreasureShow.AddId(builder, Id);
    return FB_TreasureShow.EndFB_TreasureShow(builder);
  }

  public static void StartFB_TreasureShow(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTreasureType(FlatBufferBuilder builder, int TreasureType) { builder.AddInt(1, TreasureType, 0); }
  public static void AddLevelMin(FlatBufferBuilder builder, int LevelMin) { builder.AddInt(2, LevelMin, -1); }
  public static void AddLevelMax(FlatBufferBuilder builder, int LevelMax) { builder.AddInt(3, LevelMax, -1); }
  public static void AddRateShowTitle(FlatBufferBuilder builder, int RateShowTitle) { builder.AddInt(4, RateShowTitle, -1); }
  public static void AddRateShowDesc(FlatBufferBuilder builder, int RateShowDesc) { builder.AddInt(5, RateShowDesc, -1); }
  public static void AddFreeDrop(FlatBufferBuilder builder, int FreeDrop) { builder.AddInt(6, FreeDrop, -1); }
  public static void AddMdId(FlatBufferBuilder builder, int MdId) { builder.AddInt(7, MdId, -1); }
  public static void AddDropId(FlatBufferBuilder builder, int DropId) { builder.AddInt(8, DropId, -1); }
  public static void AddBig(FlatBufferBuilder builder, StringOffset BigOffset) { builder.AddOffset(9, BigOffset.Value, 0); }
  public static void AddShowItemIDList(FlatBufferBuilder builder, VectorOffset ShowItemIDListOffset) { builder.AddOffset(10, ShowItemIDListOffset.Value, 0); }
  public static VectorOffset CreateShowItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(11, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TreasureShow> EndFB_TreasureShow(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TreasureShow>(o);
  }
};

public sealed class FB_TreasureShowContainer : Table {
  public static FB_TreasureShowContainer GetRootAsFB_TreasureShowContainer(ByteBuffer _bb) { return GetRootAsFB_TreasureShowContainer(_bb, new FB_TreasureShowContainer()); }
  public static FB_TreasureShowContainer GetRootAsFB_TreasureShowContainer(ByteBuffer _bb, FB_TreasureShowContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TreasureShowContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TreasureShowContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TreasureShow GetItems(int j) { return GetItems(new FB_TreasureShow(), j); }
  public FB_TreasureShow GetItems(FB_TreasureShow obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TreasureShowContainer> CreateFB_TreasureShowContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TreasureShowContainer.AddItems(builder, items);
    return FB_TreasureShowContainer.EndFB_TreasureShowContainer(builder);
  }

  public static void StartFB_TreasureShowContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TreasureShow>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TreasureShowContainer> EndFB_TreasureShowContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TreasureShowContainer>(o);
  }
  public static void FinishFB_TreasureShowContainerBuffer(FlatBufferBuilder builder, Offset<FB_TreasureShowContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
