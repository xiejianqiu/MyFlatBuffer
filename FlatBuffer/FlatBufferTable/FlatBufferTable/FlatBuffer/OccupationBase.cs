// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_OccupationBase : Table {
  public static FB_OccupationBase GetRootAsFB_OccupationBase(ByteBuffer _bb) { return GetRootAsFB_OccupationBase(_bb, new FB_OccupationBase()); }
  public static FB_OccupationBase GetRootAsFB_OccupationBase(ByteBuffer _bb, FB_OccupationBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_OccupationBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MenPaiName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int RoleBaseId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSkillList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SkillListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int StarSoulSkillId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DefaultModel { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FemaleModel { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DefaultWeapon { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float HghtAdjstNmbrd { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_OccupationBase> CreateFB_OccupationBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset MenPaiName = default(StringOffset),
      int RoleBaseId = -1,
      VectorOffset SkillList = default(VectorOffset),
      int StarSoulSkillId = -1,
      int DefaultModel = -1,
      int FemaleModel = -1,
      int DefaultWeapon = -1,
      float HghtAdjstNmbrd = 0) {
    builder.StartObject(9);
    FB_OccupationBase.AddHghtAdjstNmbrd(builder, HghtAdjstNmbrd);
    FB_OccupationBase.AddDefaultWeapon(builder, DefaultWeapon);
    FB_OccupationBase.AddFemaleModel(builder, FemaleModel);
    FB_OccupationBase.AddDefaultModel(builder, DefaultModel);
    FB_OccupationBase.AddStarSoulSkillId(builder, StarSoulSkillId);
    FB_OccupationBase.AddSkillList(builder, SkillList);
    FB_OccupationBase.AddRoleBaseId(builder, RoleBaseId);
    FB_OccupationBase.AddMenPaiName(builder, MenPaiName);
    FB_OccupationBase.AddID(builder, ID);
    return FB_OccupationBase.EndFB_OccupationBase(builder);
  }

  public static void StartFB_OccupationBase(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMenPaiName(FlatBufferBuilder builder, StringOffset MenPaiNameOffset) { builder.AddOffset(1, MenPaiNameOffset.Value, 0); }
  public static void AddRoleBaseId(FlatBufferBuilder builder, int RoleBaseId) { builder.AddInt(2, RoleBaseId, -1); }
  public static void AddSkillList(FlatBufferBuilder builder, VectorOffset SkillListOffset) { builder.AddOffset(3, SkillListOffset.Value, 0); }
  public static VectorOffset CreateSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStarSoulSkillId(FlatBufferBuilder builder, int StarSoulSkillId) { builder.AddInt(4, StarSoulSkillId, -1); }
  public static void AddDefaultModel(FlatBufferBuilder builder, int DefaultModel) { builder.AddInt(5, DefaultModel, -1); }
  public static void AddFemaleModel(FlatBufferBuilder builder, int FemaleModel) { builder.AddInt(6, FemaleModel, -1); }
  public static void AddDefaultWeapon(FlatBufferBuilder builder, int DefaultWeapon) { builder.AddInt(7, DefaultWeapon, -1); }
  public static void AddHghtAdjstNmbrd(FlatBufferBuilder builder, float HghtAdjstNmbrd) { builder.AddFloat(8, HghtAdjstNmbrd, 0); }
  public static Offset<FB_OccupationBase> EndFB_OccupationBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OccupationBase>(o);
  }
};

public sealed class FB_OccupationBaseContainer : Table {
  public static FB_OccupationBaseContainer GetRootAsFB_OccupationBaseContainer(ByteBuffer _bb) { return GetRootAsFB_OccupationBaseContainer(_bb, new FB_OccupationBaseContainer()); }
  public static FB_OccupationBaseContainer GetRootAsFB_OccupationBaseContainer(ByteBuffer _bb, FB_OccupationBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_OccupationBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_OccupationBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_OccupationBase GetItems(int j) { return GetItems(new FB_OccupationBase(), j); }
  public FB_OccupationBase GetItems(FB_OccupationBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_OccupationBaseContainer> CreateFB_OccupationBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_OccupationBaseContainer.AddItems(builder, items);
    return FB_OccupationBaseContainer.EndFB_OccupationBaseContainer(builder);
  }

  public static void StartFB_OccupationBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_OccupationBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_OccupationBaseContainer> EndFB_OccupationBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_OccupationBaseContainer>(o);
  }
  public static void FinishFB_OccupationBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_OccupationBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
