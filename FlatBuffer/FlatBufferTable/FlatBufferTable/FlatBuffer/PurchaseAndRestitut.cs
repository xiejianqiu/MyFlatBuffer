// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PurchaseAndRestitut : Table {
  public static FB_PurchaseAndRestitut GetRootAsFB_PurchaseAndRestitut(ByteBuffer _bb) { return GetRootAsFB_PurchaseAndRestitut(_bb, new FB_PurchaseAndRestitut()); }
  public static FB_PurchaseAndRestitut GetRootAsFB_PurchaseAndRestitut(ByteBuffer _bb, FB_PurchaseAndRestitut obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PurchaseAndRestitut __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string GetNameDesList(int j) { int o = __offset(8); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int NameDesListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUIModelIDList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UIModelIDListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int CostType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CostNum { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RestituteNum { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RestituteTime { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string TipSprite { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StrID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PurchaseAndRestitut> CreateFB_PurchaseAndRestitut(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      VectorOffset NameDesList = default(VectorOffset),
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset UIModelIDList = default(VectorOffset),
      int CostType = -1,
      int CostNum = -1,
      int RestituteNum = -1,
      int RestituteTime = -1,
      StringOffset TipSprite = default(StringOffset),
      int StrID = -1) {
    builder.StartObject(11);
    FB_PurchaseAndRestitut.AddStrID(builder, StrID);
    FB_PurchaseAndRestitut.AddTipSprite(builder, TipSprite);
    FB_PurchaseAndRestitut.AddRestituteTime(builder, RestituteTime);
    FB_PurchaseAndRestitut.AddRestituteNum(builder, RestituteNum);
    FB_PurchaseAndRestitut.AddCostNum(builder, CostNum);
    FB_PurchaseAndRestitut.AddCostType(builder, CostType);
    FB_PurchaseAndRestitut.AddUIModelIDList(builder, UIModelIDList);
    FB_PurchaseAndRestitut.AddItemIDList(builder, ItemIDList);
    FB_PurchaseAndRestitut.AddNameDesList(builder, NameDesList);
    FB_PurchaseAndRestitut.AddType(builder, Type);
    FB_PurchaseAndRestitut.AddID(builder, ID);
    return FB_PurchaseAndRestitut.EndFB_PurchaseAndRestitut(builder);
  }

  public static void StartFB_PurchaseAndRestitut(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddNameDesList(FlatBufferBuilder builder, VectorOffset NameDesListOffset) { builder.AddOffset(2, NameDesListOffset.Value, 0); }
  public static VectorOffset CreateNameDesListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNameDesListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(3, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUIModelIDList(FlatBufferBuilder builder, VectorOffset UIModelIDListOffset) { builder.AddOffset(4, UIModelIDListOffset.Value, 0); }
  public static VectorOffset CreateUIModelIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUIModelIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostType(FlatBufferBuilder builder, int CostType) { builder.AddInt(5, CostType, -1); }
  public static void AddCostNum(FlatBufferBuilder builder, int CostNum) { builder.AddInt(6, CostNum, -1); }
  public static void AddRestituteNum(FlatBufferBuilder builder, int RestituteNum) { builder.AddInt(7, RestituteNum, -1); }
  public static void AddRestituteTime(FlatBufferBuilder builder, int RestituteTime) { builder.AddInt(8, RestituteTime, -1); }
  public static void AddTipSprite(FlatBufferBuilder builder, StringOffset TipSpriteOffset) { builder.AddOffset(9, TipSpriteOffset.Value, 0); }
  public static void AddStrID(FlatBufferBuilder builder, int StrID) { builder.AddInt(10, StrID, -1); }
  public static Offset<FB_PurchaseAndRestitut> EndFB_PurchaseAndRestitut(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PurchaseAndRestitut>(o);
  }
};

public sealed class FB_PurchaseAndRestitutContainer : Table {
  public static FB_PurchaseAndRestitutContainer GetRootAsFB_PurchaseAndRestitutContainer(ByteBuffer _bb) { return GetRootAsFB_PurchaseAndRestitutContainer(_bb, new FB_PurchaseAndRestitutContainer()); }
  public static FB_PurchaseAndRestitutContainer GetRootAsFB_PurchaseAndRestitutContainer(ByteBuffer _bb, FB_PurchaseAndRestitutContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PurchaseAndRestitutContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PurchaseAndRestitutContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PurchaseAndRestitut GetItems(int j) { return GetItems(new FB_PurchaseAndRestitut(), j); }
  public FB_PurchaseAndRestitut GetItems(FB_PurchaseAndRestitut obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PurchaseAndRestitutContainer> CreateFB_PurchaseAndRestitutContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PurchaseAndRestitutContainer.AddItems(builder, items);
    return FB_PurchaseAndRestitutContainer.EndFB_PurchaseAndRestitutContainer(builder);
  }

  public static void StartFB_PurchaseAndRestitutContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PurchaseAndRestitut>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PurchaseAndRestitutContainer> EndFB_PurchaseAndRestitutContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PurchaseAndRestitutContainer>(o);
  }
  public static void FinishFB_PurchaseAndRestitutContainerBuffer(FlatBufferBuilder builder, Offset<FB_PurchaseAndRestitutContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
