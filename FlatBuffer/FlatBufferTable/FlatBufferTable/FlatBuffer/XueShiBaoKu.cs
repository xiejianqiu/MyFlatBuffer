// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_XueShiBaoKu : Table {
  public static FB_XueShiBaoKu GetRootAsFB_XueShiBaoKu(ByteBuffer _bb) { return GetRootAsFB_XueShiBaoKu(_bb, new FB_XueShiBaoKu()); }
  public static FB_XueShiBaoKu GetRootAsFB_XueShiBaoKu(ByteBuffer _bb, FB_XueShiBaoKu obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_XueShiBaoKu __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetItemIDList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetDropIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int DropIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int LvlLimit { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CopySceneId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TeamPlatformId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetCardScoreList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CardScoreListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int CardBossCom { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CardBossKill { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsCanMopUp { get { int o = __offset(22); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_XueShiBaoKu> CreateFB_XueShiBaoKu(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset DropIDList = default(VectorOffset),
      int LvlLimit = -1,
      int CopySceneId = -1,
      int TeamPlatformId = -1,
      VectorOffset CardScoreList = default(VectorOffset),
      int CardBossCom = 0,
      int CardBossKill = 0,
      bool IsCanMopUp = false) {
    builder.StartObject(10);
    FB_XueShiBaoKu.AddCardBossKill(builder, CardBossKill);
    FB_XueShiBaoKu.AddCardBossCom(builder, CardBossCom);
    FB_XueShiBaoKu.AddCardScoreList(builder, CardScoreList);
    FB_XueShiBaoKu.AddTeamPlatformId(builder, TeamPlatformId);
    FB_XueShiBaoKu.AddCopySceneId(builder, CopySceneId);
    FB_XueShiBaoKu.AddLvlLimit(builder, LvlLimit);
    FB_XueShiBaoKu.AddDropIDList(builder, DropIDList);
    FB_XueShiBaoKu.AddItemIDList(builder, ItemIDList);
    FB_XueShiBaoKu.AddId(builder, Id);
    FB_XueShiBaoKu.AddIsCanMopUp(builder, IsCanMopUp);
    return FB_XueShiBaoKu.EndFB_XueShiBaoKu(builder);
  }

  public static void StartFB_XueShiBaoKu(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(1, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDropIDList(FlatBufferBuilder builder, VectorOffset DropIDListOffset) { builder.AddOffset(2, DropIDListOffset.Value, 0); }
  public static VectorOffset CreateDropIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartDropIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLvlLimit(FlatBufferBuilder builder, int LvlLimit) { builder.AddInt(3, LvlLimit, -1); }
  public static void AddCopySceneId(FlatBufferBuilder builder, int CopySceneId) { builder.AddInt(4, CopySceneId, -1); }
  public static void AddTeamPlatformId(FlatBufferBuilder builder, int TeamPlatformId) { builder.AddInt(5, TeamPlatformId, -1); }
  public static void AddCardScoreList(FlatBufferBuilder builder, VectorOffset CardScoreListOffset) { builder.AddOffset(6, CardScoreListOffset.Value, 0); }
  public static VectorOffset CreateCardScoreListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCardScoreListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCardBossCom(FlatBufferBuilder builder, int CardBossCom) { builder.AddInt(7, CardBossCom, 0); }
  public static void AddCardBossKill(FlatBufferBuilder builder, int CardBossKill) { builder.AddInt(8, CardBossKill, 0); }
  public static void AddIsCanMopUp(FlatBufferBuilder builder, bool IsCanMopUp) { builder.AddBool(9, IsCanMopUp, false); }
  public static Offset<FB_XueShiBaoKu> EndFB_XueShiBaoKu(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XueShiBaoKu>(o);
  }
};

public sealed class FB_XueShiBaoKuContainer : Table {
  public static FB_XueShiBaoKuContainer GetRootAsFB_XueShiBaoKuContainer(ByteBuffer _bb) { return GetRootAsFB_XueShiBaoKuContainer(_bb, new FB_XueShiBaoKuContainer()); }
  public static FB_XueShiBaoKuContainer GetRootAsFB_XueShiBaoKuContainer(ByteBuffer _bb, FB_XueShiBaoKuContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_XueShiBaoKuContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_XueShiBaoKuContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_XueShiBaoKu GetItems(int j) { return GetItems(new FB_XueShiBaoKu(), j); }
  public FB_XueShiBaoKu GetItems(FB_XueShiBaoKu obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_XueShiBaoKuContainer> CreateFB_XueShiBaoKuContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_XueShiBaoKuContainer.AddItems(builder, items);
    return FB_XueShiBaoKuContainer.EndFB_XueShiBaoKuContainer(builder);
  }

  public static void StartFB_XueShiBaoKuContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_XueShiBaoKu>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_XueShiBaoKuContainer> EndFB_XueShiBaoKuContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_XueShiBaoKuContainer>(o);
  }
  public static void FinishFB_XueShiBaoKuContainerBuffer(FlatBufferBuilder builder, Offset<FB_XueShiBaoKuContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
