// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ZhongShenDian : Table {
  public static FB_ZhongShenDian GetRootAsFB_ZhongShenDian(ByteBuffer _bb) { return GetRootAsFB_ZhongShenDian(_bb, new FB_ZhongShenDian()); }
  public static FB_ZhongShenDian GetRootAsFB_ZhongShenDian(ByteBuffer _bb, FB_ZhongShenDian obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ZhongShenDian __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Icon { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string EffectName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ShenDianPoint { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TitleId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardItemId { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int RewardItemCount { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<FB_ZhongShenDian> CreateFB_ZhongShenDian(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Icon = default(StringOffset),
      StringOffset EffectName = default(StringOffset),
      int ShenDianPoint = 0,
      int TitleId = 0,
      int RewardItemId = 0,
      int RewardItemCount = 0) {
    builder.StartObject(7);
    FB_ZhongShenDian.AddRewardItemCount(builder, RewardItemCount);
    FB_ZhongShenDian.AddRewardItemId(builder, RewardItemId);
    FB_ZhongShenDian.AddTitleId(builder, TitleId);
    FB_ZhongShenDian.AddShenDianPoint(builder, ShenDianPoint);
    FB_ZhongShenDian.AddEffectName(builder, EffectName);
    FB_ZhongShenDian.AddIcon(builder, Icon);
    FB_ZhongShenDian.AddID(builder, ID);
    return FB_ZhongShenDian.EndFB_ZhongShenDian(builder);
  }

  public static void StartFB_ZhongShenDian(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(1, IconOffset.Value, 0); }
  public static void AddEffectName(FlatBufferBuilder builder, StringOffset EffectNameOffset) { builder.AddOffset(2, EffectNameOffset.Value, 0); }
  public static void AddShenDianPoint(FlatBufferBuilder builder, int ShenDianPoint) { builder.AddInt(3, ShenDianPoint, 0); }
  public static void AddTitleId(FlatBufferBuilder builder, int TitleId) { builder.AddInt(4, TitleId, 0); }
  public static void AddRewardItemId(FlatBufferBuilder builder, int RewardItemId) { builder.AddInt(5, RewardItemId, 0); }
  public static void AddRewardItemCount(FlatBufferBuilder builder, int RewardItemCount) { builder.AddInt(6, RewardItemCount, 0); }
  public static Offset<FB_ZhongShenDian> EndFB_ZhongShenDian(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ZhongShenDian>(o);
  }
};

public sealed class FB_ZhongShenDianContainer : Table {
  public static FB_ZhongShenDianContainer GetRootAsFB_ZhongShenDianContainer(ByteBuffer _bb) { return GetRootAsFB_ZhongShenDianContainer(_bb, new FB_ZhongShenDianContainer()); }
  public static FB_ZhongShenDianContainer GetRootAsFB_ZhongShenDianContainer(ByteBuffer _bb, FB_ZhongShenDianContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ZhongShenDianContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ZhongShenDianContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ZhongShenDian GetItems(int j) { return GetItems(new FB_ZhongShenDian(), j); }
  public FB_ZhongShenDian GetItems(FB_ZhongShenDian obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ZhongShenDianContainer> CreateFB_ZhongShenDianContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ZhongShenDianContainer.AddItems(builder, items);
    return FB_ZhongShenDianContainer.EndFB_ZhongShenDianContainer(builder);
  }

  public static void StartFB_ZhongShenDianContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ZhongShenDian>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ZhongShenDianContainer> EndFB_ZhongShenDianContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ZhongShenDianContainer>(o);
  }
  public static void FinishFB_ZhongShenDianContainerBuffer(FlatBufferBuilder builder, Offset<FB_ZhongShenDianContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
