// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LevelSealCopyScene : Table {
  public static FB_LevelSealCopyScene GetRootAsFB_LevelSealCopyScene(ByteBuffer _bb) { return GetRootAsFB_LevelSealCopyScene(_bb, new FB_LevelSealCopyScene()); }
  public static FB_LevelSealCopyScene GetRootAsFB_LevelSealCopyScene(ByteBuffer _bb, FB_LevelSealCopyScene obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LevelSealCopyScene __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CopySceneId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetShowItemList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ShowItemListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetCostValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CostValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelSealCopyScene> CreateFB_LevelSealCopyScene(FlatBufferBuilder builder,
      int ID = 0,
      int CopySceneId = -1,
      VectorOffset ShowItemList = default(VectorOffset),
      VectorOffset CostValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_LevelSealCopyScene.AddCostValueList(builder, CostValueList);
    FB_LevelSealCopyScene.AddShowItemList(builder, ShowItemList);
    FB_LevelSealCopyScene.AddCopySceneId(builder, CopySceneId);
    FB_LevelSealCopyScene.AddID(builder, ID);
    return FB_LevelSealCopyScene.EndFB_LevelSealCopyScene(builder);
  }

  public static void StartFB_LevelSealCopyScene(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCopySceneId(FlatBufferBuilder builder, int CopySceneId) { builder.AddInt(1, CopySceneId, -1); }
  public static void AddShowItemList(FlatBufferBuilder builder, VectorOffset ShowItemListOffset) { builder.AddOffset(2, ShowItemListOffset.Value, 0); }
  public static VectorOffset CreateShowItemListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartShowItemListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCostValueList(FlatBufferBuilder builder, VectorOffset CostValueListOffset) { builder.AddOffset(3, CostValueListOffset.Value, 0); }
  public static VectorOffset CreateCostValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCostValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelSealCopyScene> EndFB_LevelSealCopyScene(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelSealCopyScene>(o);
  }
};

public sealed class FB_LevelSealCopySceneContainer : Table {
  public static FB_LevelSealCopySceneContainer GetRootAsFB_LevelSealCopySceneContainer(ByteBuffer _bb) { return GetRootAsFB_LevelSealCopySceneContainer(_bb, new FB_LevelSealCopySceneContainer()); }
  public static FB_LevelSealCopySceneContainer GetRootAsFB_LevelSealCopySceneContainer(ByteBuffer _bb, FB_LevelSealCopySceneContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LevelSealCopySceneContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LevelSealCopySceneContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LevelSealCopyScene GetItems(int j) { return GetItems(new FB_LevelSealCopyScene(), j); }
  public FB_LevelSealCopyScene GetItems(FB_LevelSealCopyScene obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LevelSealCopySceneContainer> CreateFB_LevelSealCopySceneContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LevelSealCopySceneContainer.AddItems(builder, items);
    return FB_LevelSealCopySceneContainer.EndFB_LevelSealCopySceneContainer(builder);
  }

  public static void StartFB_LevelSealCopySceneContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LevelSealCopyScene>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LevelSealCopySceneContainer> EndFB_LevelSealCopySceneContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LevelSealCopySceneContainer>(o);
  }
  public static void FinishFB_LevelSealCopySceneContainerBuffer(FlatBufferBuilder builder, Offset<FB_LevelSealCopySceneContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
