// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CardXunBaoBase : Table {
  public static FB_CardXunBaoBase GetRootAsFB_CardXunBaoBase(ByteBuffer _bb) { return GetRootAsFB_CardXunBaoBase(_bb, new FB_CardXunBaoBase()); }
  public static FB_CardXunBaoBase GetRootAsFB_CardXunBaoBase(ByteBuffer _bb, FB_CardXunBaoBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CardXunBaoBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LowDropBox { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetHighDropBoxList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighDropBoxListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHighMinCountList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighMinCountListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHighMaxCountList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HighMaxCountListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBaseRandomList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BaseRandomListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAddRandomList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AddRandomListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int ShopItemId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NeedItemId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CardXunBaoBase> CreateFB_CardXunBaoBase(FlatBufferBuilder builder,
      int Id = 0,
      int LowDropBox = -1,
      VectorOffset HighDropBoxList = default(VectorOffset),
      VectorOffset HighMinCountList = default(VectorOffset),
      VectorOffset HighMaxCountList = default(VectorOffset),
      VectorOffset BaseRandomList = default(VectorOffset),
      VectorOffset AddRandomList = default(VectorOffset),
      int ShopItemId = -1,
      int NeedItemId = -1) {
    builder.StartObject(9);
    FB_CardXunBaoBase.AddNeedItemId(builder, NeedItemId);
    FB_CardXunBaoBase.AddShopItemId(builder, ShopItemId);
    FB_CardXunBaoBase.AddAddRandomList(builder, AddRandomList);
    FB_CardXunBaoBase.AddBaseRandomList(builder, BaseRandomList);
    FB_CardXunBaoBase.AddHighMaxCountList(builder, HighMaxCountList);
    FB_CardXunBaoBase.AddHighMinCountList(builder, HighMinCountList);
    FB_CardXunBaoBase.AddHighDropBoxList(builder, HighDropBoxList);
    FB_CardXunBaoBase.AddLowDropBox(builder, LowDropBox);
    FB_CardXunBaoBase.AddId(builder, Id);
    return FB_CardXunBaoBase.EndFB_CardXunBaoBase(builder);
  }

  public static void StartFB_CardXunBaoBase(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLowDropBox(FlatBufferBuilder builder, int LowDropBox) { builder.AddInt(1, LowDropBox, -1); }
  public static void AddHighDropBoxList(FlatBufferBuilder builder, VectorOffset HighDropBoxListOffset) { builder.AddOffset(2, HighDropBoxListOffset.Value, 0); }
  public static VectorOffset CreateHighDropBoxListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighDropBoxListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighMinCountList(FlatBufferBuilder builder, VectorOffset HighMinCountListOffset) { builder.AddOffset(3, HighMinCountListOffset.Value, 0); }
  public static VectorOffset CreateHighMinCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighMinCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHighMaxCountList(FlatBufferBuilder builder, VectorOffset HighMaxCountListOffset) { builder.AddOffset(4, HighMaxCountListOffset.Value, 0); }
  public static VectorOffset CreateHighMaxCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHighMaxCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBaseRandomList(FlatBufferBuilder builder, VectorOffset BaseRandomListOffset) { builder.AddOffset(5, BaseRandomListOffset.Value, 0); }
  public static VectorOffset CreateBaseRandomListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBaseRandomListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAddRandomList(FlatBufferBuilder builder, VectorOffset AddRandomListOffset) { builder.AddOffset(6, AddRandomListOffset.Value, 0); }
  public static VectorOffset CreateAddRandomListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAddRandomListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShopItemId(FlatBufferBuilder builder, int ShopItemId) { builder.AddInt(7, ShopItemId, -1); }
  public static void AddNeedItemId(FlatBufferBuilder builder, int NeedItemId) { builder.AddInt(8, NeedItemId, -1); }
  public static Offset<FB_CardXunBaoBase> EndFB_CardXunBaoBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardXunBaoBase>(o);
  }
};

public sealed class FB_CardXunBaoBaseContainer : Table {
  public static FB_CardXunBaoBaseContainer GetRootAsFB_CardXunBaoBaseContainer(ByteBuffer _bb) { return GetRootAsFB_CardXunBaoBaseContainer(_bb, new FB_CardXunBaoBaseContainer()); }
  public static FB_CardXunBaoBaseContainer GetRootAsFB_CardXunBaoBaseContainer(ByteBuffer _bb, FB_CardXunBaoBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CardXunBaoBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CardXunBaoBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CardXunBaoBase GetItems(int j) { return GetItems(new FB_CardXunBaoBase(), j); }
  public FB_CardXunBaoBase GetItems(FB_CardXunBaoBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CardXunBaoBaseContainer> CreateFB_CardXunBaoBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CardXunBaoBaseContainer.AddItems(builder, items);
    return FB_CardXunBaoBaseContainer.EndFB_CardXunBaoBaseContainer(builder);
  }

  public static void StartFB_CardXunBaoBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CardXunBaoBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CardXunBaoBaseContainer> EndFB_CardXunBaoBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CardXunBaoBaseContainer>(o);
  }
  public static void FinishFB_CardXunBaoBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_CardXunBaoBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
