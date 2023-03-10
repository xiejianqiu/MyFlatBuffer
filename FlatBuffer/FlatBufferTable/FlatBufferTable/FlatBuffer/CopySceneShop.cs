// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_CopySceneShop : Table {
  public static FB_CopySceneShop GetRootAsFB_CopySceneShop(ByteBuffer _bb) { return GetRootAsFB_CopySceneShop(_bb, new FB_CopySceneShop()); }
  public static FB_CopySceneShop GetRootAsFB_CopySceneShop(ByteBuffer _bb, FB_CopySceneShop obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_CopySceneShop __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AwardItemId { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ConsumNum { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ConsumItemId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelLimit { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Score { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Component { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int JieLvl { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsBind { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }

  public static Offset<FB_CopySceneShop> CreateFB_CopySceneShop(FlatBufferBuilder builder,
      int ID = 0,
      int AwardItemId = -1,
      int ConsumNum = -1,
      int ConsumItemId = -1,
      int LevelLimit = 0,
      int Score = 0,
      int Component = -1,
      int JieLvl = -1,
      bool IsBind = true) {
    builder.StartObject(9);
    FB_CopySceneShop.AddJieLvl(builder, JieLvl);
    FB_CopySceneShop.AddComponent(builder, Component);
    FB_CopySceneShop.AddScore(builder, Score);
    FB_CopySceneShop.AddLevelLimit(builder, LevelLimit);
    FB_CopySceneShop.AddConsumItemId(builder, ConsumItemId);
    FB_CopySceneShop.AddConsumNum(builder, ConsumNum);
    FB_CopySceneShop.AddAwardItemId(builder, AwardItemId);
    FB_CopySceneShop.AddID(builder, ID);
    FB_CopySceneShop.AddIsBind(builder, IsBind);
    return FB_CopySceneShop.EndFB_CopySceneShop(builder);
  }

  public static void StartFB_CopySceneShop(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddAwardItemId(FlatBufferBuilder builder, int AwardItemId) { builder.AddInt(1, AwardItemId, -1); }
  public static void AddConsumNum(FlatBufferBuilder builder, int ConsumNum) { builder.AddInt(2, ConsumNum, -1); }
  public static void AddConsumItemId(FlatBufferBuilder builder, int ConsumItemId) { builder.AddInt(3, ConsumItemId, -1); }
  public static void AddLevelLimit(FlatBufferBuilder builder, int LevelLimit) { builder.AddInt(4, LevelLimit, 0); }
  public static void AddScore(FlatBufferBuilder builder, int Score) { builder.AddInt(5, Score, 0); }
  public static void AddComponent(FlatBufferBuilder builder, int Component) { builder.AddInt(6, Component, -1); }
  public static void AddJieLvl(FlatBufferBuilder builder, int JieLvl) { builder.AddInt(7, JieLvl, -1); }
  public static void AddIsBind(FlatBufferBuilder builder, bool IsBind) { builder.AddBool(8, IsBind, true); }
  public static Offset<FB_CopySceneShop> EndFB_CopySceneShop(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneShop>(o);
  }
};

public sealed class FB_CopySceneShopContainer : Table {
  public static FB_CopySceneShopContainer GetRootAsFB_CopySceneShopContainer(ByteBuffer _bb) { return GetRootAsFB_CopySceneShopContainer(_bb, new FB_CopySceneShopContainer()); }
  public static FB_CopySceneShopContainer GetRootAsFB_CopySceneShopContainer(ByteBuffer _bb, FB_CopySceneShopContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_CopySceneShopContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_CopySceneShopContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_CopySceneShop GetItems(int j) { return GetItems(new FB_CopySceneShop(), j); }
  public FB_CopySceneShop GetItems(FB_CopySceneShop obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_CopySceneShopContainer> CreateFB_CopySceneShopContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_CopySceneShopContainer.AddItems(builder, items);
    return FB_CopySceneShopContainer.EndFB_CopySceneShopContainer(builder);
  }

  public static void StartFB_CopySceneShopContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_CopySceneShop>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_CopySceneShopContainer> EndFB_CopySceneShopContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_CopySceneShopContainer>(o);
  }
  public static void FinishFB_CopySceneShopContainerBuffer(FlatBufferBuilder builder, Offset<FB_CopySceneShopContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
