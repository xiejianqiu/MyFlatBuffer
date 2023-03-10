// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CombatPetScene : Table {
  public static FB_CombatPetScene GetRootAsFB_CombatPetScene(ByteBuffer _bb) { return GetRootAsFB_CombatPetScene(_bb, new FB_CombatPetScene()); }
  public static FB_CombatPetScene GetRootAsFB_CombatPetScene(ByteBuffer _bb, FB_CombatPetScene obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CombatPetScene __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string StageName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int StageType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CombatPetBaseId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemListList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemListListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public string GetSceneDescList(int j) { int o = __offset(14); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int SceneDescListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public string GetSceneInfoList(int j) { int o = __offset(16); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int SceneInfoListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CombatPetScene> CreateFB_CombatPetScene(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset StageName = default(StringOffset),
      int StageType = -1,
      int CombatPetBaseId = -1,
      VectorOffset ItemListList = default(VectorOffset),
      VectorOffset SceneDescList = default(VectorOffset),
      VectorOffset SceneInfoList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_CombatPetScene.AddSceneInfoList(builder, SceneInfoList);
    FB_CombatPetScene.AddSceneDescList(builder, SceneDescList);
    FB_CombatPetScene.AddItemListList(builder, ItemListList);
    FB_CombatPetScene.AddCombatPetBaseId(builder, CombatPetBaseId);
    FB_CombatPetScene.AddStageType(builder, StageType);
    FB_CombatPetScene.AddStageName(builder, StageName);
    FB_CombatPetScene.AddId(builder, Id);
    return FB_CombatPetScene.EndFB_CombatPetScene(builder);
  }

  public static void StartFB_CombatPetScene(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddStageName(FlatBufferBuilder builder, StringOffset StageNameOffset) { builder.AddOffset(1, StageNameOffset.Value, 0); }
  public static void AddStageType(FlatBufferBuilder builder, int StageType) { builder.AddInt(2, StageType, -1); }
  public static void AddCombatPetBaseId(FlatBufferBuilder builder, int CombatPetBaseId) { builder.AddInt(3, CombatPetBaseId, -1); }
  public static void AddItemListList(FlatBufferBuilder builder, VectorOffset ItemListListOffset) { builder.AddOffset(4, ItemListListOffset.Value, 0); }
  public static VectorOffset CreateItemListListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemListListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSceneDescList(FlatBufferBuilder builder, VectorOffset SceneDescListOffset) { builder.AddOffset(5, SceneDescListOffset.Value, 0); }
  public static VectorOffset CreateSceneDescListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartSceneDescListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSceneInfoList(FlatBufferBuilder builder, VectorOffset SceneInfoListOffset) { builder.AddOffset(6, SceneInfoListOffset.Value, 0); }
  public static VectorOffset CreateSceneInfoListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartSceneInfoListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CombatPetScene> EndFB_CombatPetScene(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CombatPetScene>(o);
  }
};

public sealed class FB_CombatPetSceneContainer : Table {
  public static FB_CombatPetSceneContainer GetRootAsFB_CombatPetSceneContainer(ByteBuffer _bb) { return GetRootAsFB_CombatPetSceneContainer(_bb, new FB_CombatPetSceneContainer()); }
  public static FB_CombatPetSceneContainer GetRootAsFB_CombatPetSceneContainer(ByteBuffer _bb, FB_CombatPetSceneContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CombatPetSceneContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CombatPetSceneContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CombatPetScene GetItems(int j) { return GetItems(new FB_CombatPetScene(), j); }
  public FB_CombatPetScene GetItems(FB_CombatPetScene obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CombatPetSceneContainer> CreateFB_CombatPetSceneContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CombatPetSceneContainer.AddItems(builder, items);
    return FB_CombatPetSceneContainer.EndFB_CombatPetSceneContainer(builder);
  }

  public static void StartFB_CombatPetSceneContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CombatPetScene>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CombatPetSceneContainer> EndFB_CombatPetSceneContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CombatPetSceneContainer>(o);
  }
  public static void FinishFB_CombatPetSceneContainerBuffer(FlatBufferBuilder builder, Offset<FB_CombatPetSceneContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
