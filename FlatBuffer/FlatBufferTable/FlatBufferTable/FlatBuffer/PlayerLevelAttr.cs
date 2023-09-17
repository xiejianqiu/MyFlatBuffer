// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PlayerLevelAttr : Table {
  public static FB_PlayerLevelAttr GetRootAsFB_PlayerLevelAttr(ByteBuffer _bb) { return GetRootAsFB_PlayerLevelAttr(_bb, new FB_PlayerLevelAttr()); }
  public static FB_PlayerLevelAttr GetRootAsFB_PlayerLevelAttr(ByteBuffer _bb, FB_PlayerLevelAttr obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PlayerLevelAttr __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string RoleID { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Level { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxHP { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PAttack { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MAttack { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int PMDefense { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Hit { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Dodge { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Critical { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MaxVitality { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PlayerLevelAttr> CreateFB_PlayerLevelAttr(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset RoleID = default(StringOffset),
      int level = 0,
      int MaxHP = 0,
      int PAttack = 0,
      int MAttack = 0,
      int PMDefense = 0,
      int Hit = 0,
      int Dodge = 0,
      int Critical = 0,
      int MaxVitality = -1) {
    builder.StartObject(11);
    FB_PlayerLevelAttr.AddMaxVitality(builder, MaxVitality);
    FB_PlayerLevelAttr.AddCritical(builder, Critical);
    FB_PlayerLevelAttr.AddDodge(builder, Dodge);
    FB_PlayerLevelAttr.AddHit(builder, Hit);
    FB_PlayerLevelAttr.AddPMDefense(builder, PMDefense);
    FB_PlayerLevelAttr.AddMAttack(builder, MAttack);
    FB_PlayerLevelAttr.AddPAttack(builder, PAttack);
    FB_PlayerLevelAttr.AddMaxHP(builder, MaxHP);
    FB_PlayerLevelAttr.AddLevel(builder, level);
    FB_PlayerLevelAttr.AddRoleID(builder, RoleID);
    FB_PlayerLevelAttr.AddId(builder, Id);
    return FB_PlayerLevelAttr.EndFB_PlayerLevelAttr(builder);
  }

  public static void StartFB_PlayerLevelAttr(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddRoleID(FlatBufferBuilder builder, StringOffset RoleIDOffset) { builder.AddOffset(1, RoleIDOffset.Value, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(2, level, 0); }
  public static void AddMaxHP(FlatBufferBuilder builder, int MaxHP) { builder.AddInt(3, MaxHP, 0); }
  public static void AddPAttack(FlatBufferBuilder builder, int PAttack) { builder.AddInt(4, PAttack, 0); }
  public static void AddMAttack(FlatBufferBuilder builder, int MAttack) { builder.AddInt(5, MAttack, 0); }
  public static void AddPMDefense(FlatBufferBuilder builder, int PMDefense) { builder.AddInt(6, PMDefense, 0); }
  public static void AddHit(FlatBufferBuilder builder, int Hit) { builder.AddInt(7, Hit, 0); }
  public static void AddDodge(FlatBufferBuilder builder, int Dodge) { builder.AddInt(8, Dodge, 0); }
  public static void AddCritical(FlatBufferBuilder builder, int Critical) { builder.AddInt(9, Critical, 0); }
  public static void AddMaxVitality(FlatBufferBuilder builder, int MaxVitality) { builder.AddInt(10, MaxVitality, -1); }
  public static Offset<FB_PlayerLevelAttr> EndFB_PlayerLevelAttr(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerLevelAttr>(o);
  }
};

public sealed class FB_PlayerLevelAttrContainer : Table {
  public static FB_PlayerLevelAttrContainer GetRootAsFB_PlayerLevelAttrContainer(ByteBuffer _bb) { return GetRootAsFB_PlayerLevelAttrContainer(_bb, new FB_PlayerLevelAttrContainer()); }
  public static FB_PlayerLevelAttrContainer GetRootAsFB_PlayerLevelAttrContainer(ByteBuffer _bb, FB_PlayerLevelAttrContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PlayerLevelAttrContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PlayerLevelAttrContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PlayerLevelAttr GetItems(int j) { return GetItems(new FB_PlayerLevelAttr(), j); }
  public FB_PlayerLevelAttr GetItems(FB_PlayerLevelAttr obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PlayerLevelAttrContainer> CreateFB_PlayerLevelAttrContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PlayerLevelAttrContainer.AddItems(builder, items);
    return FB_PlayerLevelAttrContainer.EndFB_PlayerLevelAttrContainer(builder);
  }

  public static void StartFB_PlayerLevelAttrContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PlayerLevelAttr>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PlayerLevelAttrContainer> EndFB_PlayerLevelAttrContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PlayerLevelAttrContainer>(o);
  }
  public static void FinishFB_PlayerLevelAttrContainerBuffer(FlatBufferBuilder builder, Offset<FB_PlayerLevelAttrContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
