// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RongYaoSuit : Table {
  public static FB_RongYaoSuit GetRootAsFB_RongYaoSuit(ByteBuffer _bb) { return GetRootAsFB_RongYaoSuit(_bb, new FB_RongYaoSuit()); }
  public static FB_RongYaoSuit GetRootAsFB_RongYaoSuit(ByteBuffer _bb, FB_RongYaoSuit obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RongYaoSuit __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string SuitName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetTotalFakeObjIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TotalFakeObjIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int SkillID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Background { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetMenPaiWeaponList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiWeaponListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMenPaiClothesList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MenPaiClothesListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemIdList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RongYaoSuit> CreateFB_RongYaoSuit(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset SuitName = default(StringOffset),
      VectorOffset TotalFakeObjIDList = default(VectorOffset),
      int SkillID = -1,
      StringOffset Background = default(StringOffset),
      VectorOffset MenPaiWeaponList = default(VectorOffset),
      VectorOffset MenPaiClothesList = default(VectorOffset),
      VectorOffset ItemIdList = default(VectorOffset)) {
    builder.StartObject(8);
    FB_RongYaoSuit.AddItemIdList(builder, ItemIdList);
    FB_RongYaoSuit.AddMenPaiClothesList(builder, MenPaiClothesList);
    FB_RongYaoSuit.AddMenPaiWeaponList(builder, MenPaiWeaponList);
    FB_RongYaoSuit.AddBackground(builder, Background);
    FB_RongYaoSuit.AddSkillID(builder, SkillID);
    FB_RongYaoSuit.AddTotalFakeObjIDList(builder, TotalFakeObjIDList);
    FB_RongYaoSuit.AddSuitName(builder, SuitName);
    FB_RongYaoSuit.AddId(builder, Id);
    return FB_RongYaoSuit.EndFB_RongYaoSuit(builder);
  }

  public static void StartFB_RongYaoSuit(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddSuitName(FlatBufferBuilder builder, StringOffset SuitNameOffset) { builder.AddOffset(1, SuitNameOffset.Value, 0); }
  public static void AddTotalFakeObjIDList(FlatBufferBuilder builder, VectorOffset TotalFakeObjIDListOffset) { builder.AddOffset(2, TotalFakeObjIDListOffset.Value, 0); }
  public static VectorOffset CreateTotalFakeObjIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTotalFakeObjIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillID(FlatBufferBuilder builder, int SkillID) { builder.AddInt(3, SkillID, -1); }
  public static void AddBackground(FlatBufferBuilder builder, StringOffset BackgroundOffset) { builder.AddOffset(4, BackgroundOffset.Value, 0); }
  public static void AddMenPaiWeaponList(FlatBufferBuilder builder, VectorOffset MenPaiWeaponListOffset) { builder.AddOffset(5, MenPaiWeaponListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiWeaponListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiWeaponListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMenPaiClothesList(FlatBufferBuilder builder, VectorOffset MenPaiClothesListOffset) { builder.AddOffset(6, MenPaiClothesListOffset.Value, 0); }
  public static VectorOffset CreateMenPaiClothesListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMenPaiClothesListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(7, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RongYaoSuit> EndFB_RongYaoSuit(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RongYaoSuit>(o);
  }
};

public sealed class FB_RongYaoSuitContainer : Table {
  public static FB_RongYaoSuitContainer GetRootAsFB_RongYaoSuitContainer(ByteBuffer _bb) { return GetRootAsFB_RongYaoSuitContainer(_bb, new FB_RongYaoSuitContainer()); }
  public static FB_RongYaoSuitContainer GetRootAsFB_RongYaoSuitContainer(ByteBuffer _bb, FB_RongYaoSuitContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RongYaoSuitContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RongYaoSuitContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RongYaoSuit GetItems(int j) { return GetItems(new FB_RongYaoSuit(), j); }
  public FB_RongYaoSuit GetItems(FB_RongYaoSuit obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RongYaoSuitContainer> CreateFB_RongYaoSuitContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RongYaoSuitContainer.AddItems(builder, items);
    return FB_RongYaoSuitContainer.EndFB_RongYaoSuitContainer(builder);
  }

  public static void StartFB_RongYaoSuitContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RongYaoSuit>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RongYaoSuitContainer> EndFB_RongYaoSuitContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RongYaoSuitContainer>(o);
  }
  public static void FinishFB_RongYaoSuitContainerBuffer(FlatBufferBuilder builder, Offset<FB_RongYaoSuitContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
