// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TimeLimitBag : Table {
  public static FB_TimeLimitBag GetRootAsFB_TimeLimitBag(ByteBuffer _bb) { return GetRootAsFB_TimeLimitBag(_bb, new FB_TimeLimitBag()); }
  public static FB_TimeLimitBag GetRootAsFB_TimeLimitBag(ByteBuffer _bb, FB_TimeLimitBag obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TimeLimitBag __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OpenType { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenServerDay { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BagPrice { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BagMaxPrice { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetRewardIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetRewardCountList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int RewardCountListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int MailId { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string TabSprite { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DesSprite { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_TimeLimitBag> CreateFB_TimeLimitBag(FlatBufferBuilder builder,
      int ID = 0,
      int OpenType = -1,
      int OpenServerDay = -1,
      int BagPrice = -1,
      int BagMaxPrice = -1,
      VectorOffset RewardIDList = default(VectorOffset),
      VectorOffset RewardCountList = default(VectorOffset),
      int MailId = -1,
      StringOffset TabSprite = default(StringOffset),
      StringOffset DesSprite = default(StringOffset)) {
    builder.StartObject(10);
    FB_TimeLimitBag.AddDesSprite(builder, DesSprite);
    FB_TimeLimitBag.AddTabSprite(builder, TabSprite);
    FB_TimeLimitBag.AddMailId(builder, MailId);
    FB_TimeLimitBag.AddRewardCountList(builder, RewardCountList);
    FB_TimeLimitBag.AddRewardIDList(builder, RewardIDList);
    FB_TimeLimitBag.AddBagMaxPrice(builder, BagMaxPrice);
    FB_TimeLimitBag.AddBagPrice(builder, BagPrice);
    FB_TimeLimitBag.AddOpenServerDay(builder, OpenServerDay);
    FB_TimeLimitBag.AddOpenType(builder, OpenType);
    FB_TimeLimitBag.AddID(builder, ID);
    return FB_TimeLimitBag.EndFB_TimeLimitBag(builder);
  }

  public static void StartFB_TimeLimitBag(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddOpenType(FlatBufferBuilder builder, int OpenType) { builder.AddInt(1, OpenType, -1); }
  public static void AddOpenServerDay(FlatBufferBuilder builder, int OpenServerDay) { builder.AddInt(2, OpenServerDay, -1); }
  public static void AddBagPrice(FlatBufferBuilder builder, int BagPrice) { builder.AddInt(3, BagPrice, -1); }
  public static void AddBagMaxPrice(FlatBufferBuilder builder, int BagMaxPrice) { builder.AddInt(4, BagMaxPrice, -1); }
  public static void AddRewardIDList(FlatBufferBuilder builder, VectorOffset RewardIDListOffset) { builder.AddOffset(5, RewardIDListOffset.Value, 0); }
  public static VectorOffset CreateRewardIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardCountList(FlatBufferBuilder builder, VectorOffset RewardCountListOffset) { builder.AddOffset(6, RewardCountListOffset.Value, 0); }
  public static VectorOffset CreateRewardCountListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartRewardCountListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMailId(FlatBufferBuilder builder, int MailId) { builder.AddInt(7, MailId, -1); }
  public static void AddTabSprite(FlatBufferBuilder builder, StringOffset TabSpriteOffset) { builder.AddOffset(8, TabSpriteOffset.Value, 0); }
  public static void AddDesSprite(FlatBufferBuilder builder, StringOffset DesSpriteOffset) { builder.AddOffset(9, DesSpriteOffset.Value, 0); }
  public static Offset<FB_TimeLimitBag> EndFB_TimeLimitBag(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TimeLimitBag>(o);
  }
};

public sealed class FB_TimeLimitBagContainer : Table {
  public static FB_TimeLimitBagContainer GetRootAsFB_TimeLimitBagContainer(ByteBuffer _bb) { return GetRootAsFB_TimeLimitBagContainer(_bb, new FB_TimeLimitBagContainer()); }
  public static FB_TimeLimitBagContainer GetRootAsFB_TimeLimitBagContainer(ByteBuffer _bb, FB_TimeLimitBagContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TimeLimitBagContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TimeLimitBagContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TimeLimitBag GetItems(int j) { return GetItems(new FB_TimeLimitBag(), j); }
  public FB_TimeLimitBag GetItems(FB_TimeLimitBag obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TimeLimitBagContainer> CreateFB_TimeLimitBagContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TimeLimitBagContainer.AddItems(builder, items);
    return FB_TimeLimitBagContainer.EndFB_TimeLimitBagContainer(builder);
  }

  public static void StartFB_TimeLimitBagContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TimeLimitBag>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TimeLimitBagContainer> EndFB_TimeLimitBagContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TimeLimitBagContainer>(o);
  }
  public static void FinishFB_TimeLimitBagContainerBuffer(FlatBufferBuilder builder, Offset<FB_TimeLimitBagContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
