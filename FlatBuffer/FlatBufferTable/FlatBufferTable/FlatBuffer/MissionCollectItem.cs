// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionCollectItem : Table {
  public static FB_MissionCollectItem GetRootAsFB_MissionCollectItem(ByteBuffer _bb) { return GetRootAsFB_MissionCollectItem(_bb, new FB_MissionCollectItem()); }
  public static FB_MissionCollectItem GetRootAsFB_MissionCollectItem(ByteBuffer _bb, FB_MissionCollectItem obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionCollectItem __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Index { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int SceneId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GroupPointID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GroupPointCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RandomPosID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MonsterID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsTeamCollect { get { int o = __offset(18); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int SkillId { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MissionCollectItem> CreateFB_MissionCollectItem(FlatBufferBuilder builder,
      int Index = 0,
      int SceneId = -1,
      int GroupPointID = -1,
      int GroupPointCount = 0,
      int RandomPosID = -1,
      int MonsterID = -1,
      int ItemID = -1,
      bool IsTeamCollect = false,
      int SkillId = -1) {
    builder.StartObject(9);
    FB_MissionCollectItem.AddSkillId(builder, SkillId);
    FB_MissionCollectItem.AddItemID(builder, ItemID);
    FB_MissionCollectItem.AddMonsterID(builder, MonsterID);
    FB_MissionCollectItem.AddRandomPosID(builder, RandomPosID);
    FB_MissionCollectItem.AddGroupPointCount(builder, GroupPointCount);
    FB_MissionCollectItem.AddGroupPointID(builder, GroupPointID);
    FB_MissionCollectItem.AddSceneId(builder, SceneId);
    FB_MissionCollectItem.AddIndex(builder, Index);
    FB_MissionCollectItem.AddIsTeamCollect(builder, IsTeamCollect);
    return FB_MissionCollectItem.EndFB_MissionCollectItem(builder);
  }

  public static void StartFB_MissionCollectItem(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddIndex(FlatBufferBuilder builder, int Index) { builder.AddInt(0, Index, 0); }
  public static void AddSceneId(FlatBufferBuilder builder, int SceneId) { builder.AddInt(1, SceneId, -1); }
  public static void AddGroupPointID(FlatBufferBuilder builder, int GroupPointID) { builder.AddInt(2, GroupPointID, -1); }
  public static void AddGroupPointCount(FlatBufferBuilder builder, int GroupPointCount) { builder.AddInt(3, GroupPointCount, 0); }
  public static void AddRandomPosID(FlatBufferBuilder builder, int RandomPosID) { builder.AddInt(4, RandomPosID, -1); }
  public static void AddMonsterID(FlatBufferBuilder builder, int MonsterID) { builder.AddInt(5, MonsterID, -1); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(6, ItemID, -1); }
  public static void AddIsTeamCollect(FlatBufferBuilder builder, bool IsTeamCollect) { builder.AddBool(7, IsTeamCollect, false); }
  public static void AddSkillId(FlatBufferBuilder builder, int SkillId) { builder.AddInt(8, SkillId, -1); }
  public static Offset<FB_MissionCollectItem> EndFB_MissionCollectItem(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionCollectItem>(o);
  }
};

public sealed class FB_MissionCollectItemContainer : Table {
  public static FB_MissionCollectItemContainer GetRootAsFB_MissionCollectItemContainer(ByteBuffer _bb) { return GetRootAsFB_MissionCollectItemContainer(_bb, new FB_MissionCollectItemContainer()); }
  public static FB_MissionCollectItemContainer GetRootAsFB_MissionCollectItemContainer(ByteBuffer _bb, FB_MissionCollectItemContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionCollectItemContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionCollectItemContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionCollectItem GetItems(int j) { return GetItems(new FB_MissionCollectItem(), j); }
  public FB_MissionCollectItem GetItems(FB_MissionCollectItem obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionCollectItemContainer> CreateFB_MissionCollectItemContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionCollectItemContainer.AddItems(builder, items);
    return FB_MissionCollectItemContainer.EndFB_MissionCollectItemContainer(builder);
  }

  public static void StartFB_MissionCollectItemContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionCollectItem>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionCollectItemContainer> EndFB_MissionCollectItemContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionCollectItemContainer>(o);
  }
  public static void FinishFB_MissionCollectItemContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionCollectItemContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
