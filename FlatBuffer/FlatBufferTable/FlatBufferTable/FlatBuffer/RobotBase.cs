// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_RobotBase : Table {
  public static FB_RobotBase GetRootAsFB_RobotBase(ByteBuffer _bb) { return GetRootAsFB_RobotBase(_bb, new FB_RobotBase()); }
  public static FB_RobotBase GetRootAsFB_RobotBase(ByteBuffer _bb, FB_RobotBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_RobotBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RoleId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MenPai { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MinRobotCombat { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaxRobotCombat { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int HairModelID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WeaponModelID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FaceId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Realm { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Wing { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassiveSkillList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RobotBase> CreateFB_RobotBase(FlatBufferBuilder builder,
      int ID = 0,
      int RoleId = -1,
      int MenPai = -1,
      int MinRobotCombat = -1,
      int MaxRobotCombat = -1,
      int HairModelID = -1,
      int WeaponModelID = -1,
      int FaceId = -1,
      int Realm = -1,
      int Wing = -1,
      VectorOffset PassiveSkillList = default(VectorOffset)) {
    builder.StartObject(11);
    FB_RobotBase.AddPassiveSkillList(builder, PassiveSkillList);
    FB_RobotBase.AddWing(builder, Wing);
    FB_RobotBase.AddRealm(builder, Realm);
    FB_RobotBase.AddFaceId(builder, FaceId);
    FB_RobotBase.AddWeaponModelID(builder, WeaponModelID);
    FB_RobotBase.AddHairModelID(builder, HairModelID);
    FB_RobotBase.AddMaxRobotCombat(builder, MaxRobotCombat);
    FB_RobotBase.AddMinRobotCombat(builder, MinRobotCombat);
    FB_RobotBase.AddMenPai(builder, MenPai);
    FB_RobotBase.AddRoleId(builder, RoleId);
    FB_RobotBase.AddID(builder, ID);
    return FB_RobotBase.EndFB_RobotBase(builder);
  }

  public static void StartFB_RobotBase(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddRoleId(FlatBufferBuilder builder, int RoleId) { builder.AddInt(1, RoleId, -1); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(2, MenPai, -1); }
  public static void AddMinRobotCombat(FlatBufferBuilder builder, int MinRobotCombat) { builder.AddInt(3, MinRobotCombat, -1); }
  public static void AddMaxRobotCombat(FlatBufferBuilder builder, int MaxRobotCombat) { builder.AddInt(4, MaxRobotCombat, -1); }
  public static void AddHairModelID(FlatBufferBuilder builder, int HairModelID) { builder.AddInt(5, HairModelID, -1); }
  public static void AddWeaponModelID(FlatBufferBuilder builder, int WeaponModelID) { builder.AddInt(6, WeaponModelID, -1); }
  public static void AddFaceId(FlatBufferBuilder builder, int FaceId) { builder.AddInt(7, FaceId, -1); }
  public static void AddRealm(FlatBufferBuilder builder, int Realm) { builder.AddInt(8, Realm, -1); }
  public static void AddWing(FlatBufferBuilder builder, int Wing) { builder.AddInt(9, Wing, -1); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(10, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RobotBase> EndFB_RobotBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RobotBase>(o);
  }
};

public sealed class FB_RobotBaseContainer : Table {
  public static FB_RobotBaseContainer GetRootAsFB_RobotBaseContainer(ByteBuffer _bb) { return GetRootAsFB_RobotBaseContainer(_bb, new FB_RobotBaseContainer()); }
  public static FB_RobotBaseContainer GetRootAsFB_RobotBaseContainer(ByteBuffer _bb, FB_RobotBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_RobotBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_RobotBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_RobotBase GetItems(int j) { return GetItems(new FB_RobotBase(), j); }
  public FB_RobotBase GetItems(FB_RobotBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_RobotBaseContainer> CreateFB_RobotBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_RobotBaseContainer.AddItems(builder, items);
    return FB_RobotBaseContainer.EndFB_RobotBaseContainer(builder);
  }

  public static void StartFB_RobotBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_RobotBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_RobotBaseContainer> EndFB_RobotBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_RobotBaseContainer>(o);
  }
  public static void FinishFB_RobotBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_RobotBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
