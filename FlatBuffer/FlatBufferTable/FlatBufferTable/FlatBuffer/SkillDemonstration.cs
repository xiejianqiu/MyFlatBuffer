// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillDemonstration : Table {
  public static FB_SkillDemonstration GetRootAsFB_SkillDemonstration(ByteBuffer _bb) { return GetRootAsFB_SkillDemonstration(_bb, new FB_SkillDemonstration()); }
  public static FB_SkillDemonstration GetRootAsFB_SkillDemonstration(ByteBuffer _bb, FB_SkillDemonstration obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillDemonstration __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EffectId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPassiveSkillList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PassiveSkillListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public string GetSkillList(int j) { int o = __offset(10); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int SkillListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int CharModelId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float PosX { get { int o = __offset(14); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosY { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float PosZ { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }

  public static Offset<FB_SkillDemonstration> CreateFB_SkillDemonstration(FlatBufferBuilder builder,
      int ID = 0,
      int EffectId = -1,
      VectorOffset PassiveSkillList = default(VectorOffset),
      VectorOffset SkillList = default(VectorOffset),
      int CharModelId = -1,
      float PosX = 0,
      float PosY = 0,
      float PosZ = 0) {
    builder.StartObject(8);
    FB_SkillDemonstration.AddPosZ(builder, PosZ);
    FB_SkillDemonstration.AddPosY(builder, PosY);
    FB_SkillDemonstration.AddPosX(builder, PosX);
    FB_SkillDemonstration.AddCharModelId(builder, CharModelId);
    FB_SkillDemonstration.AddSkillList(builder, SkillList);
    FB_SkillDemonstration.AddPassiveSkillList(builder, PassiveSkillList);
    FB_SkillDemonstration.AddEffectId(builder, EffectId);
    FB_SkillDemonstration.AddID(builder, ID);
    return FB_SkillDemonstration.EndFB_SkillDemonstration(builder);
  }

  public static void StartFB_SkillDemonstration(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddEffectId(FlatBufferBuilder builder, int EffectId) { builder.AddInt(1, EffectId, -1); }
  public static void AddPassiveSkillList(FlatBufferBuilder builder, VectorOffset PassiveSkillListOffset) { builder.AddOffset(2, PassiveSkillListOffset.Value, 0); }
  public static VectorOffset CreatePassiveSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPassiveSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillList(FlatBufferBuilder builder, VectorOffset SkillListOffset) { builder.AddOffset(3, SkillListOffset.Value, 0); }
  public static VectorOffset CreateSkillListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCharModelId(FlatBufferBuilder builder, int CharModelId) { builder.AddInt(4, CharModelId, -1); }
  public static void AddPosX(FlatBufferBuilder builder, float PosX) { builder.AddFloat(5, PosX, 0); }
  public static void AddPosY(FlatBufferBuilder builder, float PosY) { builder.AddFloat(6, PosY, 0); }
  public static void AddPosZ(FlatBufferBuilder builder, float PosZ) { builder.AddFloat(7, PosZ, 0); }
  public static Offset<FB_SkillDemonstration> EndFB_SkillDemonstration(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillDemonstration>(o);
  }
};

public sealed class FB_SkillDemonstrationContainer : Table {
  public static FB_SkillDemonstrationContainer GetRootAsFB_SkillDemonstrationContainer(ByteBuffer _bb) { return GetRootAsFB_SkillDemonstrationContainer(_bb, new FB_SkillDemonstrationContainer()); }
  public static FB_SkillDemonstrationContainer GetRootAsFB_SkillDemonstrationContainer(ByteBuffer _bb, FB_SkillDemonstrationContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillDemonstrationContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillDemonstrationContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillDemonstration GetItems(int j) { return GetItems(new FB_SkillDemonstration(), j); }
  public FB_SkillDemonstration GetItems(FB_SkillDemonstration obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillDemonstrationContainer> CreateFB_SkillDemonstrationContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillDemonstrationContainer.AddItems(builder, items);
    return FB_SkillDemonstrationContainer.EndFB_SkillDemonstrationContainer(builder);
  }

  public static void StartFB_SkillDemonstrationContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillDemonstration>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillDemonstrationContainer> EndFB_SkillDemonstrationContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillDemonstrationContainer>(o);
  }
  public static void FinishFB_SkillDemonstrationContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillDemonstrationContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
