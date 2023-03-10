// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_EquipStrengthen : Table {
  public static FB_EquipStrengthen GetRootAsFB_EquipStrengthen(ByteBuffer _bb) { return GetRootAsFB_EquipStrengthen(_bb, new FB_EquipStrengthen()); }
  public static FB_EquipStrengthen GetRootAsFB_EquipStrengthen(ByteBuffer _bb, FB_EquipStrengthen obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_EquipStrengthen __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelNow { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMaterialList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaterialListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetMaterialNumList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MaterialNumListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetProbabilityList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ProbabilityListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetSpProbabilityList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SpProbabilityListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int Exp { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SpExp { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxExp { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxHP { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PAttack { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MAttack { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PDefense { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MDefense { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrValueList(int j) { int o = __offset(32); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(32); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipStrengthen> CreateFB_EquipStrengthen(FlatBufferBuilder builder,
      int Id = 0,
      int LevelNow = -1,
      VectorOffset MaterialList = default(VectorOffset),
      VectorOffset MaterialNumList = default(VectorOffset),
      VectorOffset ProbabilityList = default(VectorOffset),
      VectorOffset SpProbabilityList = default(VectorOffset),
      int Exp = -1,
      int SpExp = -1,
      int MaxExp = -1,
      int MaxHP = -1,
      int PAttack = -1,
      int MAttack = -1,
      int PDefense = -1,
      int MDefense = -1,
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(15);
    FB_EquipStrengthen.AddAttrValueList(builder, AttrValueList);
    FB_EquipStrengthen.AddMDefense(builder, MDefense);
    FB_EquipStrengthen.AddPDefense(builder, PDefense);
    FB_EquipStrengthen.AddMAttack(builder, MAttack);
    FB_EquipStrengthen.AddPAttack(builder, PAttack);
    FB_EquipStrengthen.AddMaxHP(builder, MaxHP);
    FB_EquipStrengthen.AddMaxExp(builder, MaxExp);
    FB_EquipStrengthen.AddSpExp(builder, SpExp);
    FB_EquipStrengthen.AddExp(builder, Exp);
    FB_EquipStrengthen.AddSpProbabilityList(builder, SpProbabilityList);
    FB_EquipStrengthen.AddProbabilityList(builder, ProbabilityList);
    FB_EquipStrengthen.AddMaterialNumList(builder, MaterialNumList);
    FB_EquipStrengthen.AddMaterialList(builder, MaterialList);
    FB_EquipStrengthen.AddLevelNow(builder, LevelNow);
    FB_EquipStrengthen.AddId(builder, Id);
    return FB_EquipStrengthen.EndFB_EquipStrengthen(builder);
  }

  public static void StartFB_EquipStrengthen(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevelNow(FlatBufferBuilder builder, int LevelNow) { builder.AddInt(1, LevelNow, -1); }
  public static void AddMaterialList(FlatBufferBuilder builder, VectorOffset MaterialListOffset) { builder.AddOffset(2, MaterialListOffset.Value, 0); }
  public static VectorOffset CreateMaterialListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaterialListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaterialNumList(FlatBufferBuilder builder, VectorOffset MaterialNumListOffset) { builder.AddOffset(3, MaterialNumListOffset.Value, 0); }
  public static VectorOffset CreateMaterialNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMaterialNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddProbabilityList(FlatBufferBuilder builder, VectorOffset ProbabilityListOffset) { builder.AddOffset(4, ProbabilityListOffset.Value, 0); }
  public static VectorOffset CreateProbabilityListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartProbabilityListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSpProbabilityList(FlatBufferBuilder builder, VectorOffset SpProbabilityListOffset) { builder.AddOffset(5, SpProbabilityListOffset.Value, 0); }
  public static VectorOffset CreateSpProbabilityListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSpProbabilityListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(6, Exp, -1); }
  public static void AddSpExp(FlatBufferBuilder builder, int SpExp) { builder.AddInt(7, SpExp, -1); }
  public static void AddMaxExp(FlatBufferBuilder builder, int MaxExp) { builder.AddInt(8, MaxExp, -1); }
  public static void AddMaxHP(FlatBufferBuilder builder, int MaxHP) { builder.AddInt(9, MaxHP, -1); }
  public static void AddPAttack(FlatBufferBuilder builder, int PAttack) { builder.AddInt(10, PAttack, -1); }
  public static void AddMAttack(FlatBufferBuilder builder, int MAttack) { builder.AddInt(11, MAttack, -1); }
  public static void AddPDefense(FlatBufferBuilder builder, int PDefense) { builder.AddInt(12, PDefense, -1); }
  public static void AddMDefense(FlatBufferBuilder builder, int MDefense) { builder.AddInt(13, MDefense, -1); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(14, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipStrengthen> EndFB_EquipStrengthen(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipStrengthen>(o);
  }
};

public sealed class FB_EquipStrengthenContainer : Table {
  public static FB_EquipStrengthenContainer GetRootAsFB_EquipStrengthenContainer(ByteBuffer _bb) { return GetRootAsFB_EquipStrengthenContainer(_bb, new FB_EquipStrengthenContainer()); }
  public static FB_EquipStrengthenContainer GetRootAsFB_EquipStrengthenContainer(ByteBuffer _bb, FB_EquipStrengthenContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_EquipStrengthenContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_EquipStrengthenContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_EquipStrengthen GetItems(int j) { return GetItems(new FB_EquipStrengthen(), j); }
  public FB_EquipStrengthen GetItems(FB_EquipStrengthen obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_EquipStrengthenContainer> CreateFB_EquipStrengthenContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_EquipStrengthenContainer.AddItems(builder, items);
    return FB_EquipStrengthenContainer.EndFB_EquipStrengthenContainer(builder);
  }

  public static void StartFB_EquipStrengthenContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_EquipStrengthen>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_EquipStrengthenContainer> EndFB_EquipStrengthenContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_EquipStrengthenContainer>(o);
  }
  public static void FinishFB_EquipStrengthenContainerBuffer(FlatBufferBuilder builder, Offset<FB_EquipStrengthenContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
