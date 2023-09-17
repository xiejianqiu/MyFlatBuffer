// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GodWeaponBase : Table {
  public static FB_GodWeaponBase GetRootAsFB_GodWeaponBase(ByteBuffer _bb) { return GetRootAsFB_GodWeaponBase(_bb, new FB_GodWeaponBase()); }
  public static FB_GodWeaponBase GetRootAsFB_GodWeaponBase(ByteBuffer _bb, FB_GodWeaponBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GodWeaponBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Desc { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Name { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetItemIDList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemExpList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemExpListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int FakeobjID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassiveSkillIdList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillIdListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetUnlockLevelList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UnlockLevelListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public string Icon { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Order { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_GodWeaponBase> CreateFB_GodWeaponBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Desc = default(StringOffset),
      StringOffset Name = default(StringOffset),
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemExpList = default(VectorOffset),
      int FakeobjID = -1,
      VectorOffset PassiveSkillIdList = default(VectorOffset),
      VectorOffset UnlockLevelList = default(VectorOffset),
      StringOffset Icon = default(StringOffset),
      int Order = 0) {
    builder.StartObject(10);
    FB_GodWeaponBase.AddOrder(builder, Order);
    FB_GodWeaponBase.AddIcon(builder, Icon);
    FB_GodWeaponBase.AddUnlockLevelList(builder, UnlockLevelList);
    FB_GodWeaponBase.AddPassiveSkillIdList(builder, PassiveSkillIdList);
    FB_GodWeaponBase.AddFakeobjID(builder, FakeobjID);
    FB_GodWeaponBase.AddItemExpList(builder, ItemExpList);
    FB_GodWeaponBase.AddItemIDList(builder, ItemIDList);
    FB_GodWeaponBase.AddName(builder, Name);
    FB_GodWeaponBase.AddDesc(builder, Desc);
    FB_GodWeaponBase.AddID(builder, ID);
    return FB_GodWeaponBase.EndFB_GodWeaponBase(builder);
  }

  public static void StartFB_GodWeaponBase(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddDesc(FlatBufferBuilder builder, StringOffset DescOffset) { builder.AddOffset(1, DescOffset.Value, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(2, NameOffset.Value, 0); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(3, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemExpList(FlatBufferBuilder builder, VectorOffset ItemExpListOffset) { builder.AddOffset(4, ItemExpListOffset.Value, 0); }
  public static VectorOffset CreateItemExpListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemExpListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFakeobjID(FlatBufferBuilder builder, int FakeobjID) { builder.AddInt(5, FakeobjID, -1); }
  public static void AddPassiveSkillIdList(FlatBufferBuilder builder, VectorOffset PassiveSkillIdListOffset) { builder.AddOffset(6, PassiveSkillIdListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddUnlockLevelList(FlatBufferBuilder builder, VectorOffset UnlockLevelListOffset) { builder.AddOffset(7, UnlockLevelListOffset.Value, 0); }
  public static VectorOffset CreateUnlockLevelListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUnlockLevelListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(8, IconOffset.Value, 0); }
  public static void AddOrder(FlatBufferBuilder builder, int Order) { builder.AddInt(9, Order, 0); }
  public static Offset<FB_GodWeaponBase> EndFB_GodWeaponBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GodWeaponBase>(o);
  }
};

public sealed class FB_GodWeaponBaseContainer : Table {
  public static FB_GodWeaponBaseContainer GetRootAsFB_GodWeaponBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GodWeaponBaseContainer(_bb, new FB_GodWeaponBaseContainer()); }
  public static FB_GodWeaponBaseContainer GetRootAsFB_GodWeaponBaseContainer(ByteBuffer _bb, FB_GodWeaponBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GodWeaponBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GodWeaponBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GodWeaponBase GetItems(int j) { return GetItems(new FB_GodWeaponBase(), j); }
  public FB_GodWeaponBase GetItems(FB_GodWeaponBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GodWeaponBaseContainer> CreateFB_GodWeaponBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GodWeaponBaseContainer.AddItems(builder, items);
    return FB_GodWeaponBaseContainer.EndFB_GodWeaponBaseContainer(builder);
  }

  public static void StartFB_GodWeaponBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GodWeaponBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GodWeaponBaseContainer> EndFB_GodWeaponBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GodWeaponBaseContainer>(o);
  }
  public static void FinishFB_GodWeaponBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GodWeaponBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
