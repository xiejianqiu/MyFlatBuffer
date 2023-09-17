// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ActivityDaZhiGouShow : Table {
  public static FB_ActivityDaZhiGouShow GetRootAsFB_ActivityDaZhiGouShow(ByteBuffer _bb) { return GetRootAsFB_ActivityDaZhiGouShow(_bb, new FB_ActivityDaZhiGouShow()); }
  public static FB_ActivityDaZhiGouShow GetRootAsFB_ActivityDaZhiGouShow(ByteBuffer _bb, FB_ActivityDaZhiGouShow obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ActivityDaZhiGouShow __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string Texture { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DesSprite { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string RewardBG { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string CloseSpr { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int SkillID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetFakeObjIDList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FakeObjIDListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int Combat { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string TopDesSprite { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_ActivityDaZhiGouShow> CreateFB_ActivityDaZhiGouShow(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      StringOffset Texture = default(StringOffset),
      StringOffset DesSprite = default(StringOffset),
      StringOffset RewardBG = default(StringOffset),
      StringOffset CloseSpr = default(StringOffset),
      int SkillID = -1,
      VectorOffset FakeObjIDList = default(VectorOffset),
      int Combat = -1,
      StringOffset TopDesSprite = default(StringOffset)) {
    builder.StartObject(10);
    FB_ActivityDaZhiGouShow.AddTopDesSprite(builder, TopDesSprite);
    FB_ActivityDaZhiGouShow.AddCombat(builder, Combat);
    FB_ActivityDaZhiGouShow.AddFakeObjIDList(builder, FakeObjIDList);
    FB_ActivityDaZhiGouShow.AddSkillID(builder, SkillID);
    FB_ActivityDaZhiGouShow.AddCloseSpr(builder, CloseSpr);
    FB_ActivityDaZhiGouShow.AddRewardBG(builder, RewardBG);
    FB_ActivityDaZhiGouShow.AddDesSprite(builder, DesSprite);
    FB_ActivityDaZhiGouShow.AddTexture(builder, Texture);
    FB_ActivityDaZhiGouShow.AddType(builder, Type);
    FB_ActivityDaZhiGouShow.AddID(builder, ID);
    return FB_ActivityDaZhiGouShow.EndFB_ActivityDaZhiGouShow(builder);
  }

  public static void StartFB_ActivityDaZhiGouShow(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddTexture(FlatBufferBuilder builder, StringOffset TextureOffset) { builder.AddOffset(2, TextureOffset.Value, 0); }
  public static void AddDesSprite(FlatBufferBuilder builder, StringOffset DesSpriteOffset) { builder.AddOffset(3, DesSpriteOffset.Value, 0); }
  public static void AddRewardBG(FlatBufferBuilder builder, StringOffset RewardBGOffset) { builder.AddOffset(4, RewardBGOffset.Value, 0); }
  public static void AddCloseSpr(FlatBufferBuilder builder, StringOffset CloseSprOffset) { builder.AddOffset(5, CloseSprOffset.Value, 0); }
  public static void AddSkillID(FlatBufferBuilder builder, int SkillID) { builder.AddInt(6, SkillID, -1); }
  public static void AddFakeObjIDList(FlatBufferBuilder builder, VectorOffset FakeObjIDListOffset) { builder.AddOffset(7, FakeObjIDListOffset.Value, 0); }
  public static VectorOffset CreateFakeObjIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFakeObjIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCombat(FlatBufferBuilder builder, int Combat) { builder.AddInt(8, Combat, -1); }
  public static void AddTopDesSprite(FlatBufferBuilder builder, StringOffset TopDesSpriteOffset) { builder.AddOffset(9, TopDesSpriteOffset.Value, 0); }
  public static Offset<FB_ActivityDaZhiGouShow> EndFB_ActivityDaZhiGouShow(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityDaZhiGouShow>(o);
  }
};

public sealed class FB_ActivityDaZhiGouShowContainer : Table {
  public static FB_ActivityDaZhiGouShowContainer GetRootAsFB_ActivityDaZhiGouShowContainer(ByteBuffer _bb) { return GetRootAsFB_ActivityDaZhiGouShowContainer(_bb, new FB_ActivityDaZhiGouShowContainer()); }
  public static FB_ActivityDaZhiGouShowContainer GetRootAsFB_ActivityDaZhiGouShowContainer(ByteBuffer _bb, FB_ActivityDaZhiGouShowContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ActivityDaZhiGouShowContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ActivityDaZhiGouShowContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ActivityDaZhiGouShow GetItems(int j) { return GetItems(new FB_ActivityDaZhiGouShow(), j); }
  public FB_ActivityDaZhiGouShow GetItems(FB_ActivityDaZhiGouShow obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ActivityDaZhiGouShowContainer> CreateFB_ActivityDaZhiGouShowContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ActivityDaZhiGouShowContainer.AddItems(builder, items);
    return FB_ActivityDaZhiGouShowContainer.EndFB_ActivityDaZhiGouShowContainer(builder);
  }

  public static void StartFB_ActivityDaZhiGouShowContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ActivityDaZhiGouShow>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ActivityDaZhiGouShowContainer> EndFB_ActivityDaZhiGouShowContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ActivityDaZhiGouShowContainer>(o);
  }
  public static void FinishFB_ActivityDaZhiGouShowContainerBuffer(FlatBufferBuilder builder, Offset<FB_ActivityDaZhiGouShowContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
