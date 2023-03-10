// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShopType : Table {
  public static FB_ShopType GetRootAsFB_ShopType(ByteBuffer _bb) { return GetRootAsFB_ShopType(_bb, new FB_ShopType()); }
  public static FB_ShopType GetRootAsFB_ShopType(ByteBuffer _bb, FB_ShopType obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShopType __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsXianGou { get { int o = __offset(6); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int RefreshType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshDataId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ManualRefreshID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshMax { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RefreshCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Name { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetTabList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TabListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public bool IsBinding { get { int o = __offset(22); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_ShopType> CreateFB_ShopType(FlatBufferBuilder builder,
      int ID = 0,
      bool IsXianGou = false,
      int RefreshType = -1,
      int RefreshDataId = -1,
      int ManualRefreshID = -1,
      int RefreshMax = -1,
      int RefreshCount = -1,
      StringOffset Name = default(StringOffset),
      VectorOffset TabList = default(VectorOffset),
      bool IsBinding = false) {
    builder.StartObject(10);
    FB_ShopType.AddTabList(builder, TabList);
    FB_ShopType.AddName(builder, Name);
    FB_ShopType.AddRefreshCount(builder, RefreshCount);
    FB_ShopType.AddRefreshMax(builder, RefreshMax);
    FB_ShopType.AddManualRefreshID(builder, ManualRefreshID);
    FB_ShopType.AddRefreshDataId(builder, RefreshDataId);
    FB_ShopType.AddRefreshType(builder, RefreshType);
    FB_ShopType.AddID(builder, ID);
    FB_ShopType.AddIsBinding(builder, IsBinding);
    FB_ShopType.AddIsXianGou(builder, IsXianGou);
    return FB_ShopType.EndFB_ShopType(builder);
  }

  public static void StartFB_ShopType(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddIsXianGou(FlatBufferBuilder builder, bool IsXianGou) { builder.AddBool(1, IsXianGou, false); }
  public static void AddRefreshType(FlatBufferBuilder builder, int RefreshType) { builder.AddInt(2, RefreshType, -1); }
  public static void AddRefreshDataId(FlatBufferBuilder builder, int RefreshDataId) { builder.AddInt(3, RefreshDataId, -1); }
  public static void AddManualRefreshID(FlatBufferBuilder builder, int ManualRefreshID) { builder.AddInt(4, ManualRefreshID, -1); }
  public static void AddRefreshMax(FlatBufferBuilder builder, int RefreshMax) { builder.AddInt(5, RefreshMax, -1); }
  public static void AddRefreshCount(FlatBufferBuilder builder, int RefreshCount) { builder.AddInt(6, RefreshCount, -1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(7, NameOffset.Value, 0); }
  public static void AddTabList(FlatBufferBuilder builder, VectorOffset TabListOffset) { builder.AddOffset(8, TabListOffset.Value, 0); }
  public static VectorOffset CreateTabListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTabListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIsBinding(FlatBufferBuilder builder, bool IsBinding) { builder.AddBool(9, IsBinding, false); }
  public static Offset<FB_ShopType> EndFB_ShopType(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShopType>(o);
  }
};

public sealed class FB_ShopTypeContainer : Table {
  public static FB_ShopTypeContainer GetRootAsFB_ShopTypeContainer(ByteBuffer _bb) { return GetRootAsFB_ShopTypeContainer(_bb, new FB_ShopTypeContainer()); }
  public static FB_ShopTypeContainer GetRootAsFB_ShopTypeContainer(ByteBuffer _bb, FB_ShopTypeContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShopTypeContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShopTypeContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShopType GetItems(int j) { return GetItems(new FB_ShopType(), j); }
  public FB_ShopType GetItems(FB_ShopType obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShopTypeContainer> CreateFB_ShopTypeContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShopTypeContainer.AddItems(builder, items);
    return FB_ShopTypeContainer.EndFB_ShopTypeContainer(builder);
  }

  public static void StartFB_ShopTypeContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShopType>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShopTypeContainer> EndFB_ShopTypeContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShopTypeContainer>(o);
  }
  public static void FinishFB_ShopTypeContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShopTypeContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
