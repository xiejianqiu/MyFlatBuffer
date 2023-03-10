// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PoseBase : Table {
  public static FB_PoseBase GetRootAsFB_PoseBase(ByteBuffer _bb) { return GetRootAsFB_PoseBase(_bb, new FB_PoseBase()); }
  public static FB_PoseBase GetRootAsFB_PoseBase(ByteBuffer _bb, FB_PoseBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PoseBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string IconPath { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int AnimationID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int TextID { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsUsePaoPao { get { int o = __offset(16); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int AchievementID { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_PoseBase> CreateFB_PoseBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset IconPath = default(StringOffset),
      int AnimationID = -1,
      int TextID = -1,
      int UnlockID = -1,
      bool IsUsePaoPao = false,
      int AchievementID = -1) {
    builder.StartObject(8);
    FB_PoseBase.AddAchievementID(builder, AchievementID);
    FB_PoseBase.AddUnlockID(builder, UnlockID);
    FB_PoseBase.AddTextID(builder, TextID);
    FB_PoseBase.AddAnimationID(builder, AnimationID);
    FB_PoseBase.AddIconPath(builder, IconPath);
    FB_PoseBase.AddName(builder, Name);
    FB_PoseBase.AddId(builder, Id);
    FB_PoseBase.AddIsUsePaoPao(builder, IsUsePaoPao);
    return FB_PoseBase.EndFB_PoseBase(builder);
  }

  public static void StartFB_PoseBase(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIconPath(FlatBufferBuilder builder, StringOffset IconPathOffset) { builder.AddOffset(2, IconPathOffset.Value, 0); }
  public static void AddAnimationID(FlatBufferBuilder builder, int AnimationID) { builder.AddInt(3, AnimationID, -1); }
  public static void AddTextID(FlatBufferBuilder builder, int TextID) { builder.AddInt(4, TextID, -1); }
  public static void AddUnlockID(FlatBufferBuilder builder, int UnlockID) { builder.AddInt(5, UnlockID, -1); }
  public static void AddIsUsePaoPao(FlatBufferBuilder builder, bool IsUsePaoPao) { builder.AddBool(6, IsUsePaoPao, false); }
  public static void AddAchievementID(FlatBufferBuilder builder, int AchievementID) { builder.AddInt(7, AchievementID, -1); }
  public static Offset<FB_PoseBase> EndFB_PoseBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PoseBase>(o);
  }
};

public sealed class FB_PoseBaseContainer : Table {
  public static FB_PoseBaseContainer GetRootAsFB_PoseBaseContainer(ByteBuffer _bb) { return GetRootAsFB_PoseBaseContainer(_bb, new FB_PoseBaseContainer()); }
  public static FB_PoseBaseContainer GetRootAsFB_PoseBaseContainer(ByteBuffer _bb, FB_PoseBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PoseBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PoseBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PoseBase GetItems(int j) { return GetItems(new FB_PoseBase(), j); }
  public FB_PoseBase GetItems(FB_PoseBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PoseBaseContainer> CreateFB_PoseBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PoseBaseContainer.AddItems(builder, items);
    return FB_PoseBaseContainer.EndFB_PoseBaseContainer(builder);
  }

  public static void StartFB_PoseBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PoseBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PoseBaseContainer> EndFB_PoseBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PoseBaseContainer>(o);
  }
  public static void FinishFB_PoseBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_PoseBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
