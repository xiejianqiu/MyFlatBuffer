// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CopySceneTowerSkill : Table {
  public static FB_CopySceneTowerSkill GetRootAsFB_CopySceneTowerSkill(ByteBuffer _bb) { return GetRootAsFB_CopySceneTowerSkill(_bb, new FB_CopySceneTowerSkill()); }
  public static FB_CopySceneTowerSkill GetRootAsFB_CopySceneTowerSkill(ByteBuffer _bb, FB_CopySceneTowerSkill obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CopySceneTowerSkill __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetKZSkillIdList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int KZSkillIdListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHLSkillIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HLSkillIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCKSkillIdList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CKSkillIdListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetYJSkillIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int YJSkillIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneTowerSkill> CreateFB_CopySceneTowerSkill(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset KZSkillIdList = default(VectorOffset),
      VectorOffset HLSkillIdList = default(VectorOffset),
      VectorOffset CKSkillIdList = default(VectorOffset),
      VectorOffset YJSkillIdList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_CopySceneTowerSkill.AddYJSkillIdList(builder, YJSkillIdList);
    FB_CopySceneTowerSkill.AddCKSkillIdList(builder, CKSkillIdList);
    FB_CopySceneTowerSkill.AddHLSkillIdList(builder, HLSkillIdList);
    FB_CopySceneTowerSkill.AddKZSkillIdList(builder, KZSkillIdList);
    FB_CopySceneTowerSkill.AddId(builder, Id);
    return FB_CopySceneTowerSkill.EndFB_CopySceneTowerSkill(builder);
  }

  public static void StartFB_CopySceneTowerSkill(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddKZSkillIdList(FlatBufferBuilder builder, VectorOffset KZSkillIdListOffset) { builder.AddOffset(1, KZSkillIdListOffset.Value, 0); }
  public static VectorOffset CreateKZSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartKZSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHLSkillIdList(FlatBufferBuilder builder, VectorOffset HLSkillIdListOffset) { builder.AddOffset(2, HLSkillIdListOffset.Value, 0); }
  public static VectorOffset CreateHLSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHLSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCKSkillIdList(FlatBufferBuilder builder, VectorOffset CKSkillIdListOffset) { builder.AddOffset(3, CKSkillIdListOffset.Value, 0); }
  public static VectorOffset CreateCKSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCKSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddYJSkillIdList(FlatBufferBuilder builder, VectorOffset YJSkillIdListOffset) { builder.AddOffset(4, YJSkillIdListOffset.Value, 0); }
  public static VectorOffset CreateYJSkillIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartYJSkillIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneTowerSkill> EndFB_CopySceneTowerSkill(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneTowerSkill>(o);
  }
};

public sealed class FB_CopySceneTowerSkillContainer : Table {
  public static FB_CopySceneTowerSkillContainer GetRootAsFB_CopySceneTowerSkillContainer(ByteBuffer _bb) { return GetRootAsFB_CopySceneTowerSkillContainer(_bb, new FB_CopySceneTowerSkillContainer()); }
  public static FB_CopySceneTowerSkillContainer GetRootAsFB_CopySceneTowerSkillContainer(ByteBuffer _bb, FB_CopySceneTowerSkillContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CopySceneTowerSkillContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CopySceneTowerSkillContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CopySceneTowerSkill GetItems(int j) { return GetItems(new FB_CopySceneTowerSkill(), j); }
  public FB_CopySceneTowerSkill GetItems(FB_CopySceneTowerSkill obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneTowerSkillContainer> CreateFB_CopySceneTowerSkillContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CopySceneTowerSkillContainer.AddItems(builder, items);
    return FB_CopySceneTowerSkillContainer.EndFB_CopySceneTowerSkillContainer(builder);
  }

  public static void StartFB_CopySceneTowerSkillContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CopySceneTowerSkill>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneTowerSkillContainer> EndFB_CopySceneTowerSkillContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneTowerSkillContainer>(o);
  }
  public static void FinishFB_CopySceneTowerSkillContainerBuffer(FlatBufferBuilder builder, Offset<FB_CopySceneTowerSkillContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
