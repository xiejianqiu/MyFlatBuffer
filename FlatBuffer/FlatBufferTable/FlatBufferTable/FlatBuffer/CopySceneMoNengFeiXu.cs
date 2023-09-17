// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CopySceneMoNengFeiXu : Table {
  public static FB_CopySceneMoNengFeiXu GetRootAsFB_CopySceneMoNengFeiXu(ByteBuffer _bb) { return GetRootAsFB_CopySceneMoNengFeiXu(_bb, new FB_CopySceneMoNengFeiXu()); }
  public static FB_CopySceneMoNengFeiXu GetRootAsFB_CopySceneMoNengFeiXu(ByteBuffer _bb, FB_CopySceneMoNengFeiXu obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CopySceneMoNengFeiXu __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelLimit { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int LevelId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DropBoxID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int PassIndex { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_CopySceneMoNengFeiXu> CreateFB_CopySceneMoNengFeiXu(FlatBufferBuilder builder,
      int Id = 0,
      int LevelLimit = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      int LevelId = -1,
      int DropBoxID = -1,
      int PassIndex = -1) {
    builder.StartObject(6);
    FB_CopySceneMoNengFeiXu.AddPassIndex(builder, PassIndex);
    FB_CopySceneMoNengFeiXu.AddDropBoxID(builder, DropBoxID);
    FB_CopySceneMoNengFeiXu.AddLevelId(builder, LevelId);
    FB_CopySceneMoNengFeiXu.AddItemIDList(builder, ItemIDList);
    FB_CopySceneMoNengFeiXu.AddLevelLimit(builder, LevelLimit);
    FB_CopySceneMoNengFeiXu.AddId(builder, Id);
    return FB_CopySceneMoNengFeiXu.EndFB_CopySceneMoNengFeiXu(builder);
  }

  public static void StartFB_CopySceneMoNengFeiXu(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(1, LevelLimit, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(2, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLevelId(FlatBufferBuilder builder, int LevelId) { builder.AddInt(3, LevelId, -1); }
  public static void AddDropBoxID(FlatBufferBuilder builder, int DropBoxID) { builder.AddInt(4, DropBoxID, -1); }
  public static void AddPassIndex(FlatBufferBuilder builder, int PassIndex) { builder.AddInt(5, PassIndex, -1); }
  public static Offset<FB_CopySceneMoNengFeiXu> EndFB_CopySceneMoNengFeiXu(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneMoNengFeiXu>(o);
  }
};

public sealed class FB_CopySceneMoNengFeiXuContainer : Table {
  public static FB_CopySceneMoNengFeiXuContainer GetRootAsFB_CopySceneMoNengFeiXuContainer(ByteBuffer _bb) { return GetRootAsFB_CopySceneMoNengFeiXuContainer(_bb, new FB_CopySceneMoNengFeiXuContainer()); }
  public static FB_CopySceneMoNengFeiXuContainer GetRootAsFB_CopySceneMoNengFeiXuContainer(ByteBuffer _bb, FB_CopySceneMoNengFeiXuContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CopySceneMoNengFeiXuContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CopySceneMoNengFeiXuContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CopySceneMoNengFeiXu GetItems(int j) { return GetItems(new FB_CopySceneMoNengFeiXu(), j); }
  public FB_CopySceneMoNengFeiXu GetItems(FB_CopySceneMoNengFeiXu obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneMoNengFeiXuContainer> CreateFB_CopySceneMoNengFeiXuContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CopySceneMoNengFeiXuContainer.AddItems(builder, items);
    return FB_CopySceneMoNengFeiXuContainer.EndFB_CopySceneMoNengFeiXuContainer(builder);
  }

  public static void StartFB_CopySceneMoNengFeiXuContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CopySceneMoNengFeiXu>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneMoNengFeiXuContainer> EndFB_CopySceneMoNengFeiXuContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneMoNengFeiXuContainer>(o);
  }
  public static void FinishFB_CopySceneMoNengFeiXuContainerBuffer(FlatBufferBuilder builder, Offset<FB_CopySceneMoNengFeiXuContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
