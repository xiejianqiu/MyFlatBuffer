// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MergeRankShow : Table {
  public static FB_MergeRankShow GetRootAsFB_MergeRankShow(ByteBuffer _bb) { return GetRootAsFB_MergeRankShow(_bb, new FB_MergeRankShow()); }
  public static FB_MergeRankShow GetRootAsFB_MergeRankShow(ByteBuffer _bb, FB_MergeRankShow obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MergeRankShow __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Title { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TabText { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ConsumeDes { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RewardItemDes { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TipTitleText { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string JumpBtnIcon { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int JumpBtnIconName { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_MergeRankShow> CreateFB_MergeRankShow(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Title = default(StringOffset),
      int TabText = -1,
      int ConsumeDes = -1,
      int RewardItemDes = -1,
      int TipTitleText = -1,
      StringOffset JumpBtnIcon = default(StringOffset),
      int JumpBtnIconName = -1) {
    builder.StartObject(8);
    FB_MergeRankShow.AddJumpBtnIconName(builder, JumpBtnIconName);
    FB_MergeRankShow.AddJumpBtnIcon(builder, JumpBtnIcon);
    FB_MergeRankShow.AddTipTitleText(builder, TipTitleText);
    FB_MergeRankShow.AddRewardItemDes(builder, RewardItemDes);
    FB_MergeRankShow.AddConsumeDes(builder, ConsumeDes);
    FB_MergeRankShow.AddTabText(builder, TabText);
    FB_MergeRankShow.AddTitle(builder, Title);
    FB_MergeRankShow.AddID(builder, ID);
    return FB_MergeRankShow.EndFB_MergeRankShow(builder);
  }

  public static void StartFB_MergeRankShow(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset TitleOffset) { builder.AddOffset(1, TitleOffset.Value, 0); }
  public static void AddTabText(FlatBufferBuilder builder, int TabText) { builder.AddInt(2, TabText, -1); }
  public static void AddConsumeDes(FlatBufferBuilder builder, int ConsumeDes) { builder.AddInt(3, ConsumeDes, -1); }
  public static void AddRewardItemDes(FlatBufferBuilder builder, int RewardItemDes) { builder.AddInt(4, RewardItemDes, -1); }
  public static void AddTipTitleText(FlatBufferBuilder builder, int TipTitleText) { builder.AddInt(5, TipTitleText, -1); }
  public static void AddJumpBtnIcon(FlatBufferBuilder builder, StringOffset JumpBtnIconOffset) { builder.AddOffset(6, JumpBtnIconOffset.Value, 0); }
  public static void AddJumpBtnIconName(FlatBufferBuilder builder, int JumpBtnIconName) { builder.AddInt(7, JumpBtnIconName, -1); }
  public static Offset<FB_MergeRankShow> EndFB_MergeRankShow(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MergeRankShow>(o);
  }
};

public sealed class FB_MergeRankShowContainer : Table {
  public static FB_MergeRankShowContainer GetRootAsFB_MergeRankShowContainer(ByteBuffer _bb) { return GetRootAsFB_MergeRankShowContainer(_bb, new FB_MergeRankShowContainer()); }
  public static FB_MergeRankShowContainer GetRootAsFB_MergeRankShowContainer(ByteBuffer _bb, FB_MergeRankShowContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MergeRankShowContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MergeRankShowContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MergeRankShow GetItems(int j) { return GetItems(new FB_MergeRankShow(), j); }
  public FB_MergeRankShow GetItems(FB_MergeRankShow obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MergeRankShowContainer> CreateFB_MergeRankShowContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MergeRankShowContainer.AddItems(builder, items);
    return FB_MergeRankShowContainer.EndFB_MergeRankShowContainer(builder);
  }

  public static void StartFB_MergeRankShowContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MergeRankShow>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MergeRankShowContainer> EndFB_MergeRankShowContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MergeRankShowContainer>(o);
  }
  public static void FinishFB_MergeRankShowContainerBuffer(FlatBufferBuilder builder, Offset<FB_MergeRankShowContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
