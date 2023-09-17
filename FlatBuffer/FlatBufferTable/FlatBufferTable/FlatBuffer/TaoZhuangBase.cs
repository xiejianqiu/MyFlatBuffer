// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TaoZhuangBase : Table {
  public static FB_TaoZhuangBase GetRootAsFB_TaoZhuangBase(ByteBuffer _bb) { return GetRootAsFB_TaoZhuangBase(_bb, new FB_TaoZhuangBase()); }
  public static FB_TaoZhuangBase GetRootAsFB_TaoZhuangBase(ByteBuffer _bb, FB_TaoZhuangBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TaoZhuangBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Icon { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Level { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quantity { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ModelID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMenPaiHairList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiHairListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMenPaiClothesList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiClothesListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMenPaiWeaponList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiWeaponListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public string PeiShiQiPao { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }
  public string PeiShiTouXiang { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_TaoZhuangBase> CreateFB_TaoZhuangBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Icon = -1,
      int Level = -1,
      int Quantity = -1,
      int ModelID = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset MenPaiHairList = default(VectorOffset),
      VectorOffset MenPaiClothesList = default(VectorOffset),
      VectorOffset MenPaiWeaponList = default(VectorOffset),
      StringOffset PeiShiQiPao = default(StringOffset),
      StringOffset PeiShiTouXiang = default(StringOffset)) {
    builder.StartObject(12);
    FB_TaoZhuangBase.AddPeiShiTouXiang(builder, PeiShiTouXiang);
    FB_TaoZhuangBase.AddPeiShiQiPao(builder, PeiShiQiPao);
    FB_TaoZhuangBase.AddMenPaiWeaponList(builder, MenPaiWeaponList);
    FB_TaoZhuangBase.AddMenPaiClothesList(builder, MenPaiClothesList);
    FB_TaoZhuangBase.AddMenPaiHairList(builder, MenPaiHairList);
    FB_TaoZhuangBase.AddItemIdList(builder, ItemIdList);
    FB_TaoZhuangBase.AddModelID(builder, ModelID);
    FB_TaoZhuangBase.AddQuantity(builder, Quantity);
    FB_TaoZhuangBase.AddLevel(builder, Level);
    FB_TaoZhuangBase.AddIcon(builder, Icon);
    FB_TaoZhuangBase.AddName(builder, Name);
    FB_TaoZhuangBase.AddID(builder, ID);
    return FB_TaoZhuangBase.EndFB_TaoZhuangBase(builder);
  }

  public static void StartFB_TaoZhuangBase(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, int Icon) { builder.AddInt(2, Icon, -1); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(3, Level, -1); }
  public static void AddQuantity(FlatBufferBuilder builder, int Quantity) { builder.AddInt(4, Quantity, -1); }
  public static void AddModelID(FlatBufferBuilder builder, int ModelID) { builder.AddInt(5, ModelID, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(6, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPaiHairList(FlatBufferBuilder builder, VectorOffset MenPaiHairListOffset) { builder.AddOffset(7, MenPaiHairListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiHairListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiHairListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPaiClothesList(FlatBufferBuilder builder, VectorOffset MenPaiClothesListOffset) { builder.AddOffset(8, MenPaiClothesListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiClothesListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiClothesListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPaiWeaponList(FlatBufferBuilder builder, VectorOffset MenPaiWeaponListOffset) { builder.AddOffset(9, MenPaiWeaponListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiWeaponListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiWeaponListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPeiShiQiPao(FlatBufferBuilder builder, StringOffset PeiShiQiPaoOffset) { builder.AddOffset(10, PeiShiQiPaoOffset.Value, 0); }
  public static void AddPeiShiTouXiang(FlatBufferBuilder builder, StringOffset PeiShiTouXiangOffset) { builder.AddOffset(11, PeiShiTouXiangOffset.Value, 0); }
  public static Offset<FB_TaoZhuangBase> EndFB_TaoZhuangBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaoZhuangBase>(o);
  }
};

public sealed class FB_TaoZhuangBaseContainer : Table {
  public static FB_TaoZhuangBaseContainer GetRootAsFB_TaoZhuangBaseContainer(ByteBuffer _bb) { return GetRootAsFB_TaoZhuangBaseContainer(_bb, new FB_TaoZhuangBaseContainer()); }
  public static FB_TaoZhuangBaseContainer GetRootAsFB_TaoZhuangBaseContainer(ByteBuffer _bb, FB_TaoZhuangBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TaoZhuangBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TaoZhuangBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TaoZhuangBase GetItems(int j) { return GetItems(new FB_TaoZhuangBase(), j); }
  public FB_TaoZhuangBase GetItems(FB_TaoZhuangBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TaoZhuangBaseContainer> CreateFB_TaoZhuangBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TaoZhuangBaseContainer.AddItems(builder, items);
    return FB_TaoZhuangBaseContainer.EndFB_TaoZhuangBaseContainer(builder);
  }

  public static void StartFB_TaoZhuangBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TaoZhuangBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TaoZhuangBaseContainer> EndFB_TaoZhuangBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TaoZhuangBaseContainer>(o);
  }
  public static void FinishFB_TaoZhuangBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_TaoZhuangBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
